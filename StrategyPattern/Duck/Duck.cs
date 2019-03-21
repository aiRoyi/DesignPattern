using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public abstract class Duck
    {
        public FlyBehavior FlyBehavior;
        public QuackBehavior QuackBehavior;

        public Duck()
        {

        }
        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
        public void Swim()
        {

        }
        public abstract void Display();
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }
        public void SetQuackBehavior(QuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }
    }
}
