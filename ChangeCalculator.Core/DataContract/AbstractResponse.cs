using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public abstract class AbstractResponse
    {
        public bool Success { get; set; }
        public string Code { get; set; }

        public IDictionary<string, IList<string>> MessageCollection { get; set; }

    }
}
