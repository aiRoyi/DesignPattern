using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + "$" + beverage.cost());
            Beverage beverage2 = new DarkRoast();
            //Doubble Mocha with whip
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + "$" + beverage2.cost());
            Console.ReadLine();
        }
    }
}
