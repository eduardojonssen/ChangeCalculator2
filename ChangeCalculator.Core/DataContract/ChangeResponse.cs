using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public sealed class ChangeResponse
    {
        public string Coin { get; private set; }
        public long Quantity { get; private set; }

        public ChangeResponse(string coin, long quantity)
        {
            Coin = coin;
            Quantity = quantity;
        }
    }
}
