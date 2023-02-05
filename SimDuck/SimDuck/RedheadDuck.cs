using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("я красноголовая утка");
        }
    }
}
