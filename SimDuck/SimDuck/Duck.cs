using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void performFly()
        {
            flyBehavior.fly();
        }
        public void performQuack()
        {
            quackBehavior.quack();
        }
        public void swim()
        {
            Console.WriteLine("Буль-буль");
        }
        public abstract void display();
    }

}
