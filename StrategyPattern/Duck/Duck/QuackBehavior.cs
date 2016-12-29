using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public interface QuackBehavior
    {
        void quack();
    }
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
    public class QuackWithDuckCall : QuackBehavior
    {
        public void quack()
        {
            
        }
    }
}
