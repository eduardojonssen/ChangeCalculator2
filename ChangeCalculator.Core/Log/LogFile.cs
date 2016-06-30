using ChangeCalculator.Core.DataContract;
using Dlp.Framework;
using System;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChangeCalculator.Core.Log {
    public sealed class LogFile : AbstractLog {

        private string FilePath {
            get {
                return ConfigurationManager.AppSettings["FilePathLog"];
            }
        }
        
        public override void Write(object @object, CategoryLog categoryLog = CategoryLog.Info, string message = null, string methodName = null) {

            try {
                using (StreamWriter fileLog = GetFileLog()) {

                    string logMessage = GetFormattedLog(@object, categoryLog, message, methodName);

                    fileLog.WriteLineAsync(logMessage);
                }
            }
            catch {

               
            }             
            

        }


        private StreamWriter GetFileLog() {

            FileInfo fileLog = new FileInfo(FilePath);
            if(fileLog.Directory.Exists == false) {
                fileLog.Directory.Create();
            }
            
            if (fileLog.Exists == false) {
                return fileLog.CreateText();
            }

            return fileLog.AppendText();

        }
    }
}
