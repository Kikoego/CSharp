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
    abstract class AbstractFactoryClass
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();

        public abstract AbstractCover CreateCover();
    }
}
