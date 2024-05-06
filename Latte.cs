using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class Latte : Beverage
    {
        public override string GetDescription()
        {
            return "Latte";
        }

        public override double GetPrice()
        {
            return 2.99;
        }
    }
}
