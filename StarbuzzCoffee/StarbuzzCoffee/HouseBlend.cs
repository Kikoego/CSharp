using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend ";
        }

        public override decimal cost()
        {
            return 80;
        }
    }
}
