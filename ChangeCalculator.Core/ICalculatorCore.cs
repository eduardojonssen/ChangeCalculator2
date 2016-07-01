using ChangeCalculator.Core.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core {

    public interface ICalculatorCore {

        CalculatorChangeResponse Calculator(CalculatorChangeRequest calculatorChangeRequest);
        List<long> GetBillValues();
    }
}
