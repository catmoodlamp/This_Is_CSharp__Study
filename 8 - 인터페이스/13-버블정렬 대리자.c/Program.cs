using System;
using System.Collections.Generic;
using static System.Console;
namespace _13_버블정렬_대리자.c
{
    delegate int Compare(int a, int b);
    class CustomSorting3D2
    {
        public static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        public static int DecendCompare(int a, int b)
        {
            return AscendCompare(a, b) * -1;
        }

        public static void BubbleSort(int[] DataSet, Compare comparer)
        {
            for(int i = 0; i<DataSet.Length-1; i++)
            {
                for(int k =0; k<DataSet.Length - 1 - i; k++)
                {
                    if(comparer(DataSet[k], DataSet[k+1]) > 0)
                    {
                        int tmp = DataSet[k];
                        DataSet[k] = DataSet[k + 1];
                        DataSet[k + 1] = tmp;
                    }
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 3, 6, 36, 7, 8, };
            Compare comparer = new Compare(CustomSorting3D2.AscendCompare);
            CustomSorting3D2.BubbleSort(array, comparer);

            WriteLine("오름차 정렬 중..");
            foreach (int e in array)
                Write("{0} ", e);
            comparer = new Compare(CustomSorting3D2.DecendCompare);
            CustomSorting3D2.BubbleSort(array, comparer);
            WriteLine("\n내림차 정렬 중..");
            foreach (int e in array)
                Write("{0} ");

        }
    }
}
