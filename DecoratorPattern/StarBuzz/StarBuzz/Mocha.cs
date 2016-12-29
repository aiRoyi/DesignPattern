using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
            : base(beverage)
        {
        }
        public override double cost()
        {
            return .20 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ",Mocha";
        }
    }
}
