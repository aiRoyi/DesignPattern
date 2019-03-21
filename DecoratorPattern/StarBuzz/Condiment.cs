using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    public abstract class CondimentDecorator: Beverage
    {
        protected Beverage beverage;
        protected CondimentDecorator(Beverage obj)
        {
            this.beverage = obj;
        }
    }
}
