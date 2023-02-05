using System;

namespace SimDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck d1 = new MallardDuck();
            d1.display();
            d1.performQuack();
            d1.swim();
            d1.performFly();
            Console.WriteLine("_________");
            RedheadDuck d2 = new RedheadDuck();
            d2.display();
            d2.performQuack();
            d2.swim();
            d2.performFly();
            Console.WriteLine("_________");

            RubberDuck d3 = new RubberDuck();
            d3.display();
            d3.performQuack();
            d3.swim();
            d3.performFly();

            RubberDuck d4 = new RubberDuck();
            d4.display();
            d4.performFly();
            d4.setFlyBehavior(new FlyRocketPowered());
            d4.performFly();




        }
    }
}
