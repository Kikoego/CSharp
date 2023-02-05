using AbstractFactory.Factory;
using AbstractFactory.Water;
using AbstractFactory.Bottle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Cover;

namespace AbstractFactory.Bottle
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}
