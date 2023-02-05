using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage b1 = new Espresso();
            Console.WriteLine(b1.getDescription() + " " + b1.cost() + " руб.");

            b1 = new Mocha(b1);
            Console.WriteLine(b1.getDescription() + " " + b1.cost() + " руб.");

            Beverage b2 = new Decaf();
            Console.WriteLine(b2.getDescription() + " " + b2.cost() + " руб.");

            b2 = new Milk(b2);
            Console.WriteLine(b2.getDescription() + " " + b2.cost() + " руб.");
        }
    }
}
