using System;

namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", Moca";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .20;
        }
    }
}
