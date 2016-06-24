using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public sealed class CalculatorChangeResponse : AbstractResponse
    {       
        public ICollection<ChangeResponse> ChangeCollection { get; set; }
        
        public long SalePrice { get; set; }
        public long ValuePayment { get; set; }
        public long ChangeAmount { get; set; }

        public CalculatorChangeResponse()
        {
            MessageCollection = new List<MessageRequest>();
            ChangeCollection = new List<ChangeResponse>();
        }

        public override bool IsValid()
        {
            if (SalePrice < 0)
            {

            }

            if (ValuePayment < 0)
            {

            }

            return false;
        }
    }
}
