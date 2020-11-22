using System;
/*
 * 1.메소드를 프로퍼티로 변경\
 * 2. 무명형식 사용
 */
namespace _9_연습문제1
{
    class NameCard
    {
        private int age;
        private string name;
        public int GetAge() { return age; }
        public void SetAge(int newAge) { age = newAge; }
        public string GetName() { return name; }
        public void SetName(string value) { name = value; }

        //프로퍼티 ㅆㅅㅌㅊ
        public int PAge { get; set; }
        public string PName { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();
            MyCard.SetAge(24);
            MyCard.SetName("올리비아 사일런스");
            Console.WriteLine("나이: {0}, 이름: {1}", MyCard.GetAge(), MyCard.GetName());
            //프로퍼티 짱!
            NameCard YourCard = new NameCard();
            YourCard.PAge = 25;
            YourCard.PName = "프틸롭시스";
            Console.WriteLine("나이: {0}, 이름: {1}", YourCard.PAge, YourCard.PName);


            var nameCard = new { Name = "UMP45", Star = "4" };
            Console.WriteLine("이름: {0}, 등급: {1}성", nameCard.Name, nameCard.Star);

            var complex = new { Real = 3, Imaginary = -2 };
            Console.WriteLine("실수: {0}, 허수: {1}", complex.Real, complex.Imaginary);

        }
    }
}
