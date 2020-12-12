using System;
using System.Collections.Generic;
using static System.Console;
namespace _13_버블정렬_대리자.c
{
    delegate int Compare<T>(T a, T b);
    class CustomSorting3D2
    {
        public static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        public static int DecendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        public static void BubbleSort<T>(T[] DataSet, Compare<T> comparer)
        {
            for (int i = 0; i < DataSet.Length - 1; i++)
            {
                for (int k = 0; k < DataSet.Length - 1 - i; k++)
                {
                    if (comparer(DataSet[k], DataSet[k + 1]) > 0)
                    {
                        T tmp = DataSet[k];
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
            string[] array2 = { "모나", "각청", "파이몬", "엠버"};
            Compare<int> comparer = new Compare<int>(CustomSorting3D2.AscendCompare);
            CustomSorting3D2.BubbleSort(array, comparer);

            WriteLine("오름차 정렬 중..");
            foreach (int e in array)
                Write("{0} ", e);
            comparer = new Compare<int>(CustomSorting3D2.DecendCompare);
            CustomSorting3D2.BubbleSort(array, comparer);
            WriteLine("\n내림차 정렬 중..");
            foreach (int e in array)
                Write("{0} ",e);
            WriteLine("\n문자열 정렬 전 : ");

            foreach (string e in array2)
                Write("{0} ", e);
            CustomSorting3D2.BubbleSort<string>(array2, new Compare<string>(CustomSorting3D2.AscendCompare));

            WriteLine("정렬 후: ");
            foreach (string e in array2)
                Write("{0} ", e);
        }
    }
}
