using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }
        public override void display()
        {
            Console.WriteLine("я искуственная резиновая утка");
        }
    }
}
