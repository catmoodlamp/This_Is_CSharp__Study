using System;

namespace _13_대리자
{
    delegate int MyDelegate(int a, int b);
    class MyClass
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return (int)MathF.Abs(a - b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass math = new MyClass();
            MyDelegate Callback;
            Callback = new MyDelegate(MyClass.Plus);
            Console.WriteLine(Callback(2, 3));
            Callback = new MyDelegate(math.Minus);
            Console.WriteLine(Callback(3, 4));

        }
    }
}
