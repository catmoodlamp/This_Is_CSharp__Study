using System;
using static System.Console;
namespace _10_배열
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            arr[0] = 1;
            foreach (int array in arr)
            {
                //WriteLine(array);
            }
            int[] mona = { 1, 2, 3 };
            foreach (int a in mona)
                WriteLine(a);

            string[] amber = { "엠버불꽃X지", "각청찌릿뷰X", "설탕달콤X지", "모나첨벙뷰X" };
            WriteLine("배열 형식은 {0}", amber.GetType());
            WriteLine("정렬 전 배열:");
            foreach (string a in amber)
                WriteLine(a);
            Array.Sort(amber);
            WriteLine("정렬 후 배열:");
            foreach (string a in amber)
                WriteLine(a);

            string[][] jagged = new string[3][];
            jagged[0] = new string[3] { "모나", "각청", "클레" };
            jagged[1] = new string[] { "행자", "엠버", "파이몬" };
        }
    }
}
