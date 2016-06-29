using System.Collections.Generic;

namespace ChangeCalculator.Core.Processors {
    public class CandyProcessor : AbstractProcessor 
    {
        public override string Name {
            get {
                return "Candy";
            }
        }

        public CandyProcessor() {

            AvailableValueCollection = new List<long> {
                3, 1
            };

        }
    }
}
