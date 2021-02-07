using System;

namespace Strategy
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Quack!");
        }
    }
}
