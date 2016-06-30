using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public sealed class EventViewLog : AbstractLog {

        public override void Write(object @object, CategoryLog categoryLog = CategoryLog.Info, string message = null, [CallerMemberName] string methodName = null) {

            string logMessage = GetFormattedLog(@object, categoryLog, message, methodName);

            EventLog.WriteEntry("ChangeCalculator", logMessage, ConvertToEntryInfo(categoryLog), 234);
        }

        private EventLogEntryType ConvertToEntryInfo(CategoryLog categoryLog) 
        {
            switch (categoryLog) {                
                case CategoryLog.Error:
                    return EventLogEntryType.Error;
                case CategoryLog.Warn:
                    return EventLogEntryType.Warning;
                default:
                    return EventLogEntryType.Information;                    
            }

        }
    }
}
