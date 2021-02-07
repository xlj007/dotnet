using System;

namespace Strategy
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
