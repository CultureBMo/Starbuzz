using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    // Condiment decorator base class
    public abstract class Condiment : Beverage
    {
        protected Beverage beverage;

        public Condiment(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            if (this.beverage != null)
            {
                return this.beverage.GetDescription();
            }
            else
            {
                return string.Empty;
            }
        }

        public override double GetPrice()
        {
            if (this.beverage != null)
            {
                return this.beverage.GetPrice();
            }
            else
            {
                return 0;
            }
        }
    }
}
