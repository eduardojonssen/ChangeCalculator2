using ChangeCalculator.Core.DataContract;
using System.Collections.Generic;

namespace ChangeCalculator.Core.Interface
{
    public interface IChangeCalculator
    {
        CalculatorChangeResponse Calculator(CalculatorChangeRequest calculatorChangeRequest);
    }
}
