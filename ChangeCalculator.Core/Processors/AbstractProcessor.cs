using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
   public abstract class AbstractProcessor {

        public abstract string Name { get; }
        public List<long> AvailableValueCollection { get; protected set; }
        
        public virtual Dictionary<long, long> Process(long amount) {

            Dictionary<long, long> changeDictionary = new Dictionary<long, long>();
            if (amount <= 0)
                return changeDictionary;
            
            foreach (long value in AvailableValueCollection.OrderByDescending(x => x)) {

                long quantity = (amount / value);
                if(quantity > 0) {
                    changeDictionary.Add(value, quantity);
                }

                amount = amount % value;
            }

            return changeDictionary;
        }

    }
}
