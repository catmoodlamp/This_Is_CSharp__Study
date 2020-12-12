using System;
using System.Collections;
using static System.Console;

namespace _10_인덱서
{
    class Indexer : IEnumerable, IEnumerator
    {
        private string[] array;
        int position = -1;


        public Indexer()
        {
            array = new string[3];
        }
        public string this[int idx]
        {
            get { return array[idx]; }
            set
            {
                if (idx >= array.Length)
                {
                    Array.Resize<string>(ref array, idx + 1);
                    WriteLine($"경고: 접근한 인덱스는 배열의 길이보다 큽니다. 배열 길이를 늘립니다.\n 접근한 인덱스: {idx}\n 배열 길이: {array.Length}");
                    //길이 3 배열에 idx가 3이면 안되지.
                }
                array[idx] = value;
            }
        }
        public int Len
        {
            get { return array.Length; }
        }

        //IEnumerator
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return array[position]; }
        }
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }


        //IEnumerable
        public IEnumerator GetEnumerator()
        {
            for(int i = 0;i<array.Length; i++)
            {
                yield return array[i];
            }
        }


    }



    class MainApp
    {

        static void Main(string[] args)
        {
            Indexer indexer = new Indexer();
            for (int i = 0; i < 5; i++)
            {
                indexer[i] = "모험 경험치 + " + i * 100;
            }
            for (int i = 0; i < indexer.Len; i++)
            {
                //WriteLine(indexer[i]);
            }
            foreach (string str in indexer)
                WriteLine(str);

        }
    }

}
