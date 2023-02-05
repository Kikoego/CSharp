using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso ";
        }

        public override decimal cost()
        {
            return 100;
        }
    }
}
