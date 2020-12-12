using System;
using static System.Console;
namespace _13_대리자체인
{
    class Program
    {
        delegate void ThereIsAFire(string location);
        static void Call119(string location)
        {
            WriteLine("소방서죠? 불이 났어요! 주소는 {0}", location);
        }
        static void Shout(string location)
        {
            WriteLine("피하세요! {0}에 붙이 났어요!", location);
        }
        static void Escape(string location)
        {
            WriteLine("{0}에서 나갑시다!", location);
        }

        static void Main(string[] args)
        {
            ThereIsAFire fire = new ThereIsAFire(Call119);
            //ThereIsAFire fire
            fire += Shout;
            fire += Escape;
            fire("우리집");
            fire -= Shout;
            fire("너네집");
            ReadLine();
        }
    }
}
