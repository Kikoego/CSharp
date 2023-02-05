using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage b)
        {
            beverage = b;
        }

        public override decimal cost()
        {
            return 80 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "Soy ";
        }
    }
}
