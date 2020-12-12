using System;
using System.Collections;
using static System.Console;

namespace _10_컬랙션_초기화
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "클레맘", "각청맘", "엠버맘" };
            ArrayList list = new ArrayList(arr);
            foreach (object obj in list)
                Write(obj + " ");
            WriteLine();
            Queue queue = new Queue(arr);
            foreach (object obj in queue)
                Write(obj + " ");
            WriteLine();
            Stack stack = new Stack(arr);

            ArrayList arrayList = new ArrayList() { "헤응", "호바밧", "쮸보봅" };
            WriteLine("컬랙션 초기자를 이용한 ArrayList 초기화, 스택이랑 큐는 못함");
            foreach (object obj in arrayList)
                Write(obj + " ");

            Hashtable ht = new Hashtable()
            {
                ["엠버"] = "4성",
                ["감버"] = "5성",
                ["게이야"] = "4성"
            };


        }
    }
}
