using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class SkimmedMilk : Condiment
    {
        public SkimmedMilk(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"Skinny {base.GetDescription()}";
        }

        public override double GetPrice()
        {
            return base.GetPrice();
        }
    }
}
