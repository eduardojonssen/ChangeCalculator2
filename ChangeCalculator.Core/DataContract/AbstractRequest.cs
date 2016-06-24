using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public abstract class AbstractRequest
    {
        public IDictionary<string, IList<string>> MessageCollection { get; set; }

        public abstract bool IsValid();
    }
}
