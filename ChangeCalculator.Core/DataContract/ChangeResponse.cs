using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public sealed class ChangeResponse
    {
        public long Value { get; private set; }
        public long Quantity { get; private set; }
        public string Type { get; private set; }

        public ChangeResponse(long value, long quantity, string type)
        {
            Value = value;
            Quantity = quantity;
            Type = type;
        }
    }
}
