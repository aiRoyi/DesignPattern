using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public interface Clams
    {
    }

    public class FrozenClams : Clams
    {
        public FrozenClams()
        {
            Console.WriteLine("FrozenClams");
        }
    }

    public class FreshClams : Clams
    {
        public FreshClams()
        {
            Console.WriteLine("FreshClams");
        }
    }

    public class Clamari : Clams
    {
        public Clamari()
        {
            Console.WriteLine("Clamari");
        }
    }
}
