using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public sealed class CalculatorChangeRequest
    {
        public long SalePrice { get; set; }
        public long ValuePayment { get; set; }
                   
    }
}
