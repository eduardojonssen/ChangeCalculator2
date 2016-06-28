using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public class BillProcessor : AbstractProcessor {

        public override string Name {
            get {
                return "Bill";
            }
        }

        public BillProcessor() {

            AvailableValueCollection = new List<long> {
                10000, 5000, 2000, 1000, 500, 200
            };

        }
    }
}
