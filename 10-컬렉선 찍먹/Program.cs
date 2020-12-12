using System;
using System.Collections;
using static System.Console;
namespace _10_컬렉선_찍먹
{
    class Program
    {
        static void Main(string[] args)
        {
            //참고: ArrayList의 obj 형식은 박싱&언박싱을 통해 모든 형식을 때려박을 수 있음.(모든 형식은 obj형식을 상속하기 때문).
            //근데 박싱 언박싱이 성능 ㅆㅎㅌㅊ라 많이 쓰면 소X전선 마냥 성능저하가 발생할 것임. 그래서 일반화프로그래밍을 배운다 카더라? **아님말고**
            //ArrayList
            WriteLine("***어레이리스트!***");
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);
            foreach(object obj in list){
                Write(obj + " ");
            }
            WriteLine();
            list.RemoveAt(2);
            WriteLine("어레이리스트에서 idx 2의 원소 삭제");
            foreach (object obj in list)
                Write(obj + " ");
            WriteLine();
            list.Insert(2, "헤으응");
            WriteLine("어레이리스트의 idx 2에 헤으응 삽입");
            foreach (object obj in list)
                Write(obj + " ");

            WriteLine("");
            WriteLine("리스트에 감버찌찌 추가(list.Add(object obj)");
            list.Add("감우");
            list.Add("코코넛우유디스펜서");

            foreach (object obj in list)
                Write(obj + " ");

            WriteLine("");

            //Queue
            WriteLine("\n\n***큐!***");
            Queue queue = new Queue();
            queue.Enqueue("쥬지");
            queue.Enqueue("뷰지");
            queue.Enqueue("각청찌릿뷰지");
            queue.Enqueue("엠버따끈뷰지");

            while (queue.Count > 0)
                WriteLine(queue.Dequeue());

            //Stack
            WriteLine("\n\n***스택!***");
            Stack stack = new Stack();
            stack.Push("야 각청");
            stack.Push("왜 울고있는거야");
            stack.Push("소난다");
            stack.Push("불기둥 넣을게");
            stack.Push("**과부화**");
            while (stack.Count > 0)
                WriteLine(stack.Pop());
            //HashTable
            WriteLine("\n\n***해시테이블!***");
            Hashtable ht = new Hashtable();
            ht["엠버"] = "활잡이";
            ht["감버"] = "활잡이";
            ht["각청"] = "좆손검";

            WriteLine($"엠버 : {ht["엠버"]}\n감버 : {ht["감버"]}\n각청 : {ht["각청"]}");

        }
    }
}
