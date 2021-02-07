using System;

namespace Strategy
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
