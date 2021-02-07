using System;

namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .30;
        }
    }
}
