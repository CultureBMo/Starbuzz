using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class OatMilk : Condiment
    {
        public OatMilk(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} with Oat Milk";
        }

        public override double GetPrice()
        {
            return 0.50 + base.GetPrice();
        }
    }
}
