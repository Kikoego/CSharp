using AbstractFactory.Factory;
using AbstractFactory.Water;
using AbstractFactory.Bottle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Cover;

namespace AbstractFactory.Factory
{
    class PepsiFactory : AbstractFactoryClass
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }
    }
}
