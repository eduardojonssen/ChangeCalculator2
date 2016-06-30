using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Log {
    public static class LogFactory {
        
        public static AbstractLog Create(LogType logType) 
        {
            switch (logType) {                
                case LogType.EventViewer:
                    return new EventViewLog();                
                default:
                    return new LogFile();
            }
        }

    }
}
