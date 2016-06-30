using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public static class LogManager {


        public static void Write(object @object,
                                 CategoryLog categoryLog = CategoryLog.Info,
                                 string message = null,                                 
                                 [CallerMemberName] string methodName = null) {

            LogType logType = (LogType)Enum.Parse(typeof(LogType), ConfigurationManager.AppSettings["LogType"] ?? LogType.EventViewer.ToString());

            AbstractLog log = LogFactory.Create(logType);

            log.Write(@object, categoryLog, message, methodName);

        }

        

        

    }
}
