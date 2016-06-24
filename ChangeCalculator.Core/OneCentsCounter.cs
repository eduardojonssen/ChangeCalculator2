using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core
{
    public class OneCentsCounter : Counter
    {

        public OneCentsCounter()
            : base("1 Cent", 1) { }

        public override void Process(long amount)
        {
            Change.Quantity = amount;
        }
    }
}
