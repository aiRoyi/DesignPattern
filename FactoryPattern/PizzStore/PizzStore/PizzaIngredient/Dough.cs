using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public interface Dough
    {
    }

    public class ThinCrustDough : Dough
    {
        public ThinCrustDough()
        {
            Console.WriteLine("ThinCrustDough");
        }
    }

    public class VeryThinDough : Dough
    {
        public VeryThinDough()
        {
            Console.WriteLine("VeryThinDough");
        }
    }
}
