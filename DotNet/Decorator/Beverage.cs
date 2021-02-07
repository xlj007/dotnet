using System;

namespace Decorator
{
    public abstract class Beverage
    {
        public string Description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return this.Description;
        }

        public abstract double Cost();
    }
}
