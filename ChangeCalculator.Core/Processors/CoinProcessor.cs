using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Processors {
    public class CoinProcessor : AbstractProcessor 
    {
        public override string Name {
            get {
                return "Coin";
            }
        }

        public CoinProcessor() {

            AvailableValueCollection = new List<long> {
                100, 50, 25, 10, 5, 1
            };

        }
    }
}
