using System;

namespace Strategy
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
