using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core
{
    public class Change
    {
        public string Coin { get; private set; }
        public long Quantity { get; set; }

        public Change(string coin)
        {
            Coin = coin;
        }

        public override string ToString()
        {            
            return string.Format("{0} - {1}{2}", Coin, Quantity, Environment.NewLine);
        }
    }
}
