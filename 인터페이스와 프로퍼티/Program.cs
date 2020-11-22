using System;

namespace 인터페이스와_프로퍼티
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
    }
    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
        
    }
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID { get { return string.Format("{0:d5}", serial++); } }
        abstract public DateTime ProductDate { get; set; }

    }

    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
        public void Test() { Console.WriteLine("테스트"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            INamedValue wish  = new NamedValue() { Name = "기원", Value = "모나" };
            NamedValue real = new NamedValue() { Name = "현실", Value = "다이루크" };
            Console.WriteLine($"{wish.Name}: {wish.Value}, 그러나 {real.Name} : {real.Value}");

            //추상클래스, 복습하자면 추상클래스는 인스턴스를 가질 수 없음. 그래서 인스턴스를 만드는 행위는 무조건 파생 클래스가 해 줘야됨
            //Product testing = new Product();
            //오류: 추상 클래스의 인슨턴스를 만들 수 없습니다.  그러면 걍
            MyProduct testing = new MyProduct() { ProductDate = new DateTime(2020, 11, 18) };
            Console.WriteLine("물건:{0}, 제조일자: {1}", testing.SerialID, testing.ProductDate);
            testing.Test();
            Product product1 = new MyProduct() { ProductDate = new DateTime(2020, 11, 11) }; 
            Console.WriteLine("물건:{0}, 제조일자: {1}", product1.SerialID, product1.ProductDate);
            //product1.Test();
            //나중에 실제 추상클래스를 사용하다 보면 이해하는 날이 올까? 왜 객체는 MyProduct로 만들어놓고 형식을 그냥 Product로 할까? MyProduct의 추가 필드 따위에 접근할 수가 없는데 말이다.
            Product product2 = new MyProduct() { ProductDate = new DateTime(2020, 11, 12) };
            Console.WriteLine("물건:{0}, 제조일자: {1}", product2.SerialID, product2.ProductDate);

        }
    }
}
