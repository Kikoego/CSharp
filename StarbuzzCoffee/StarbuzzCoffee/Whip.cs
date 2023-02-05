using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage b)
        {
            beverage = b;
        }

        public override decimal cost()
        {
            return 50 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "Whip ";
        }
    }
}
