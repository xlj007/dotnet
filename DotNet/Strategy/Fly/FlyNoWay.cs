using System;

namespace Strategy
{
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I can't fly!");
        }
    }
}
