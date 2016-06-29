using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public class SilverProcessor : AbstractProcessor {

        public override string Name {
            get {
                return "Silver";
            }
        }

        public SilverProcessor() {

            AvailableValueCollection = new List<long> {
                100000, 50000
            };
        }
    }
}
