using System;

namespace Strategy
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck()
        {}

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.fly();
        }

        public void SetFlyBehavior(FlyBehavior fly)
        {
            this.flyBehavior = fly;
        }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void SetQuackBehavior(QuackBehavior quack)
        {
            this.quackBehavior = quack;
        }

        public void Swin()
        {
            System.Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
