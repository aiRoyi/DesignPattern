using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public interface FlyBehavior
    {
        void Fly();
    }
    class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying!");
        }
    }
    class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}
