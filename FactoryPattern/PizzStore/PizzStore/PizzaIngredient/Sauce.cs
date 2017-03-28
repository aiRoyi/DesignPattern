using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public interface Sauce
    {
    }

    public class PlumTomatoSauce : Sauce
    {
        public PlumTomatoSauce()
        {
            Console.WriteLine("PlumTomatoSauce");
        }
    }

    public class MarinaraSauce : Sauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine("MarinaraSauce");
        }
    }

    public class BruschettaSauce : Sauce
    {
        public BruschettaSauce()
        {
            Console.WriteLine("BruschettaSauce");
        }
    }
}
