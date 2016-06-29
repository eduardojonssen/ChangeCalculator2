using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public interface ILog {

        void Write(string message, CategoryLog categoryLog, EntryInfo entryInfo, Exception ex);
    }
}
