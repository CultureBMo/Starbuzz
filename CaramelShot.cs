using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class CaramelShot : Condiment
    {
        public CaramelShot(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} and a Caramel Shot";
        }

        public override double GetPrice()
        {
            return 1.00 + base.GetPrice();
        }
    }
}
