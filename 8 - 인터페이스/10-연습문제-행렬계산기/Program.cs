using System;

namespace _10_연습문제_행렬계산기
{

    
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] matrix2 = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            int[,] result = new int[2, 2];

            for(int i = 0; i<2; i++)
            {
                for(int k = 0; k<2; k++)
                {
                    result[i, k] = matrix1[i, k] * matrix2[i, k];
                    Console.Write(result[i, k] + " ");
                }
                Console.WriteLine("");
            }



        }
    }
}
