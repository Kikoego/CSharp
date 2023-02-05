using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("я не умею летать");
        }
    }
}
