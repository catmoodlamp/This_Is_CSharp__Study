using System;

namespace 프로퍼티
{
    class 자바충주거
    {
        private string java;
        public string Get() { return java; }
        public void Set(string newJava) { java = newJava; }
    }
    class 각청맘
    {
        private string keqingMom;
        public string Property { get { return keqingMom; } set { keqingMom = value; } }

    }
    class 각청
    {
        public string Name { get; set; } = "각청";
        public float BaseAttack { get; set; } = 0;
        public float WeaponAttack { get; set; } = 0;
        public float AttackBonus { get; set; } = 0;

        public float TotalAttack
        {
            
            get { return (BaseAttack + WeaponAttack) * MathF.Max((1.0f + AttackBonus), 0.01f); }
        }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //자바였다면..
            자바충주거 minecraft = new 자바충주거();
            minecraft.Set("헤으응");
            Console.WriteLine(minecraft.Get());

            //C#눈나라면?
            각청맘 genshin = new 각청맘();
            genshin.Property = "각청찌릿XX";
            Console.WriteLine(genshin.Property);

            //프로퍼티, 자동 구현 프로퍼티, 프로퍼티와 생성자
            각청 keqing = new 각청();
            Console.WriteLine($"{keqing.Name}의 기본 공격력 : {keqing.BaseAttack}, 무기 공격력: {keqing.WeaponAttack}, 추가 공격력 계수 : {keqing.AttackBonus}, 최종 공격력: {keqing.TotalAttack}");
            keqing.Name = "각청찌릿뷰X";
            keqing.BaseAttack = 300;
            keqing.WeaponAttack = 200;
            keqing.AttackBonus = -1.3f;
            Console.WriteLine("정보 다시 불러오는 중..");
            Console.WriteLine($"{keqing.Name}의 기본 공격력 : {keqing.BaseAttack}, 무기 공격력: {keqing.WeaponAttack}, 추가 공격력 계수 : {keqing.AttackBonus}, 최종 공격력: {keqing.TotalAttack}");

            각청 gyakru = new 각청() { Name = "갹청찌릿X지", BaseAttack = 100, AttackBonus = 1.0f, WeaponAttack = 50 };
            Console.WriteLine($"{gyakru.Name} 최종 공격력: {gyakru.TotalAttack} ");

            //무명 형식
            var kleeMom = new { Weapon = "음유시인의 악장", Artifacts = "불 위를 걷는 현인" };
            Console.WriteLine($"클레맘의 무기는 {kleeMom.Weapon}");

        }
    }
}
