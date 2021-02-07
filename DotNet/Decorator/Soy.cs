using System;

namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .10;
        }
    }
}
