using ChangeCalculator.Core.DataContract;
using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public abstract class AbstractLog {

        public abstract void Write(object @object,
                                 CategoryLog categoryLog = CategoryLog.Info,
                                 string message = null,
                                 [CallerMemberName] string methodName = null);

        protected EntryInfo GetEntryInfo(object @object) {

            EntryInfo entryInfo = EntryInfo.Other;
            if (@object is AbstractRequest) {
                entryInfo = EntryInfo.Request;
            }
            else if (@object is AbstractResponse) {
                entryInfo = EntryInfo.Response;
            }
            else if (@object is Exception) {
                entryInfo = EntryInfo.Exception;
            }

            return entryInfo;
        }

        protected string GetFormattedLog(object @object, CategoryLog categoryLog, string message, string methodName) {

            StringBuilder log = new StringBuilder();

            log.AppendLine(new string('-', 40));
            log.AppendFormat("Date: {0}", DateTime.UtcNow.ToString());
            log.AppendLine();
            log.AppendFormat("MethodName: {0}", methodName);
            log.AppendLine();
            log.AppendFormat("Category: {0}", categoryLog.ToString());
            log.AppendLine();
            log.AppendFormat("EntryInfo: {0}", GetEntryInfo(@object));
            log.AppendLine();
            log.AppendFormat("Message: {0}", message);
            log.AppendLine();

            log.AppendFormat("Object: {0}", Serializer.NewtonsoftSerialize(@object));
            log.AppendLine();

            return log.ToString();
        }
    }
}
