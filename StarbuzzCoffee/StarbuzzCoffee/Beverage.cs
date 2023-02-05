using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    abstract class Beverage
    {
        protected String description = "Unknown beverage";

        public virtual String getDescription()
        {
            return description;
        }

        public abstract decimal cost();
    }
}
