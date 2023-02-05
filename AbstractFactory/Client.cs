using AbstractFactory.Factory;
using AbstractFactory.Water;
using AbstractFactory.Bottle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Cover;

namespace AbstractFactory
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;

        public Client(AbstractFactoryClass factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
        }

        public void Run()
        {
            bottle.Interact(water);
            cover.Interact(cover);
        }
    }
}
