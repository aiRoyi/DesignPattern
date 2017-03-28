using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public interface Cheese
    {
    }

    public class MozzarellaCheese : Cheese
    {
        public MozzarellaCheese()
        {
            Console.WriteLine("MozzarellaCheese");
        }
    }

    public class ReggianoCheese : Cheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine("ReggianoCheese");
        }
    }

    public class GoatCheese : Cheese
    {
        public GoatCheese()
        {
            Console.WriteLine("GoatCheese");
        }
    }
}
