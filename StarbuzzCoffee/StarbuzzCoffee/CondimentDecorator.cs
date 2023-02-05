using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract override String getDescription();
    }
}
