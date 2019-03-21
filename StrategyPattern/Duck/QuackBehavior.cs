using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public interface QuackBehavior
    {
        void Quack();
    }
    public class DuckQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
    public class QuackWithDuckCall : QuackBehavior
    {
        public void Quack()
        {
            
        }
    }
}
