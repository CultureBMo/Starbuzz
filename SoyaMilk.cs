using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class SoyaMilk : Condiment
    {
        public SoyaMilk(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} with Soya Milk";
        }

        public override double GetPrice()
        {
            return 0.50 + base.GetPrice();
        }
    }
}
