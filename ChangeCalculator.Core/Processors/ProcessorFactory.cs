using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public static class ProcessorFactory {

        public static AbstractProcessor Create(long amount) {



            List<AbstractProcessor> processors = new List<AbstractProcessor> {

                new BillProcessor(),
                new CoinProcessor()

                //Add new processors above
            };

            foreach (AbstractProcessor processor in
                processors.OrderByDescending(x => x.AvailableValueCollection.Min())) { 

                if(amount >= processor.AvailableValueCollection.Min()) {
                    return processor;
                }
            }

            return null;
        }
    }
}
