using ChangeCalculator.Core.DataContract;
using Dlp.Framework;
using System;
using System.Configuration;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChangeCalculator.Core.Log {
    public static class LogFile{

        private static string FilePath {
            get {
                return ConfigurationManager.AppSettings["FilePathLog"];
            }
        }

        public static void Write(object @object,
                                 CategoryLog categoryLog = CategoryLog.Info,
                                 string message = null,
                                 [CallerMemberName]string methodName = null) {

            EntryInfo entryInfo = EntryInfo.Other;
            if(@object is AbstractRequest) {
                entryInfo = EntryInfo.Request;
            }
            else if(@object is AbstractResponse) {
                entryInfo = EntryInfo.Response;
            }
            else if(@object is Exception) {
                entryInfo = EntryInfo.Exception;
            }
            
            using (StreamWriter fileLog = GetFileLog()) {

                StringBuilder log = new StringBuilder();

                log.AppendLine(new string('-', 40));
                log.AppendFormat("Date: {0}", DateTime.UtcNow.ToString());
                log.AppendLine();
                log.AppendFormat("MethodName: {0}", methodName);
                log.AppendLine();
                log.AppendFormat("Category: {0}", categoryLog.ToString());
                log.AppendLine();
                log.AppendFormat("EntryInfo: {0}", entryInfo.ToString());
                log.AppendLine();                
                log.AppendFormat("Message: {0}", message);
                log.AppendLine();
                
                log.AppendFormat("Object: {0}", Serializer.NewtonsoftSerialize(@object));
                log.AppendLine();

                fileLog.WriteLine(log.ToString());
            }

        }


        private static StreamWriter GetFileLog() {

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
