using System;

namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House Blend Coffe";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
