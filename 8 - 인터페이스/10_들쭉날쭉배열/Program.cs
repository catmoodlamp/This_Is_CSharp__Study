using System;
using static System.Console;
namespace _10_들쭉날쭉배열
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach(int[] arr in jagged)
            {
                WriteLine($"길이: {arr.Length}");
                Write("원소: ");

                foreach(int element in arr)
                {
                    Write("{0} ", element);
                }
                WriteLine();
            }

            int[][] kyaru = new int[2][]
            {
                new int[]{1000,2000},
                new int[]{6,7,8,9}
            };

            foreach(int[] gyakru in kyaru)
            {
                Write("캬루 또 너야? [{0}] -> ", gyakru.Length);
                foreach (int electroSucks in gyakru)
                    Write("{0} ", electroSucks);
                WriteLine();
            }

        }
    }
}
