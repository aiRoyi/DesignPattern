using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
            : base(beverage)
        {}
        public override double cost()
        {
            return .10;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
    }
}
