using System;
using static System.Console;
namespace 추상_클래스
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            WriteLine("AbstractBase.PrivateMethodA() 실행함 ㅇㅇ");
        }
        public void PublicMethodA()
        {
            WriteLine("AbstractBase.PublicMethodA()를 실행했닥");
        }
        public abstract void AbstractMethodA();
    }
    class KleeMom: AbstractBase
    {
        public override void AbstractMethodA()
        {
            WriteLine("클레맘.AbstractMethodA() 실행함");
            PrivateMethodA();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase 각청맘 = new KleeMom();
            KleeMom 클레맘 = new KleeMom();
            클레맘.AbstractMethodA();
            클레맘.PublicMethodA();
        }
    }
}
