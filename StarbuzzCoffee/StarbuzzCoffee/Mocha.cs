using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage b)
        {
            beverage = b;
        }

        public override decimal cost()
        {
            return 30 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "Mocha ";
        }
    }
}
