using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    // Beverage base class
    public abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract double GetPrice();

        public string WriteOrder()
        {
            return $"{GetDescription()} £{GetPrice()}";
        }
    }
}
