using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public class GoldenProcessor : AbstractProcessor {

        public override string Name {
            get {
                return "Golden";
            }
        }

        public GoldenProcessor() {

            AvailableValueCollection = new List<long> {
                2000000, 1000000, 500000
            };
        }

    }
}
