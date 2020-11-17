using System;

namespace 인터페이스_다중상속
{
    interface ICollectable
    {
        void Collect();
    }
    interface IDamagable
    {
        void TakeDamage();
    }

    class SweetSweetFlower : ICollectable
    {
        public void Collect()
        {
            Console.WriteLine("획득: 달콤달콤꽃");
        }
    }
    class ChyuChyuObelisk : IDamagable
    {
        public void TakeDamage()
        {
            Console.WriteLine("츄츄 방첨탑 파괴!");
        }
    }
    class CoreButterFly: ICollectable, IDamagable
    {
        public void Collect()
        {
            Console.WriteLine("획득: 수정 코어");
        }
        public void TakeDamage()
        {
            Console.WriteLine("오브젝트 삭제");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            CoreButterFly butter = new CoreButterFly();
            butter.Collect();
            butter.TakeDamage();

            ICollectable collectable = butter as ICollectable;
            collectable.Collect();
            IDamagable damagable = butter as IDamagable;
            damagable.TakeDamage();

        }
    }
}
