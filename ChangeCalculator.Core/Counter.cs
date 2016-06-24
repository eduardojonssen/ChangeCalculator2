using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core
{
    public abstract class Counter
    {
        protected readonly long baseCalculate;
        public Change Change { get; protected set; }
        protected Counter CounterNext { get; set; }

        public Counter(string coin, long baseCalculate)
        {
            this.Change = new Change(coin);
            this.baseCalculate = baseCalculate;
        }

        public void setNext(Counter counter)
        {
            this.CounterNext = counter;
        }

        public virtual void Process(long amount)
        {
            Change.Quantity = 0;
            if (amount >= baseCalculate)
            {
                Change.Quantity = (int)(amount / baseCalculate);
            }

            var rest = amount % baseCalculate;
            if (rest > 0 && this.CounterNext != null)
            {
                this.CounterNext.Process(rest);
            }
        }
    }
}
