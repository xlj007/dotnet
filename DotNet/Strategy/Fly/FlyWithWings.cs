using System;

namespace Strategy
{
    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I'm flying!");
        }
    }
}
