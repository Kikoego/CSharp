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
    class CocaColaFactory : AbstractFactoryClass
    {
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }
    }
}
