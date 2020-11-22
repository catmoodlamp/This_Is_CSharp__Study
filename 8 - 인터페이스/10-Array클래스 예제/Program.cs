using System;
using static System.Console;
namespace _10_Array클래스_예제
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }
        private static void Print(int value)
        {
            Write($"{value} ");
        }
        static void Main(string[] args)
        {
            int[] scores = { 80, 74, 81, 90, 34 };
            foreach(int score in scores)
            {
                Write("{0} ", score);
            }
            WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            WriteLine($"본 배열은 {scores.Rank}차원 배열입니다.");

            WriteLine("이진 탐색 수행: 81은 {0}번째에 있어.", Array.BinarySearch<int>(scores, 81));
            WriteLine("선형 탐색 수행: 90은 {0}번째에 있어.", Array.IndexOf(scores, 90));

            WriteLine("모두 시험을 통과했나요? 통과 기준은 60점 이상입니다. :{0}", Array.TrueForAll<int>(scores, CheckPassed) ? "ㅇㅇ" : "ㄴㄴ");

            int idx = Array.FindIndex<int>(scores, delegate (int score)
            {
                if (score < 60)
                    return true;
                else
                    return false;
            });
            WriteLine("{0}번째 친구의 점수가 {1}라서 통과하지 못했어.", idx+1, scores[idx]);
            scores[idx] = 61;
            WriteLine("그래서 그 친구의 점수를 조작함ㅋㅋ");
            WriteLine("모두 시험을 통과했나요? 통과 기준은 60점 이상입니다. :{0}", Array.TrueForAll<int>(scores, CheckPassed) ? "ㅇㅇ" : "ㄴㄴ");

            WriteLine($"원래 배열의 길이는 {scores.GetLength(0)}");
            Array.Resize<int>(ref scores, 10);
            WriteLine($"늘린 배열의 길이는 {scores.Length}");


            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();
            Array.Clear(scores, 3,1);
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();


        }
    }
}
