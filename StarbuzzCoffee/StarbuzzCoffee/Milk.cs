using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Milk : CondimentDecorator
    {
        Beverage beverage;

        public Milk(Beverage b)
        {
            beverage = b;
        }

        public override decimal cost()
        {
            return 20 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "Milk ";
        }
    }
}
