using ChangeCalculator.Core.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public abstract class AbstractRequest
    {
        
        
        public AbstractRequest() {
            ReportCollection = new List<Report>();
        }

        internal List<Report> ReportCollection { get; set; }

        internal bool IsValid() {

            this.ReportCollection.Clear();
            this.Validate();
            return (this.ReportCollection.Any() == false);
        }

        protected abstract void Validate();

        protected void AddError(string field, string errorCode, string message) {

            Report report = new Report();

            report.ErrorCode = errorCode;
            report.Message = message;

            if (string.IsNullOrEmpty(field) == false) {
                report.Field = this.GetType().Name + "." + field;
            }           

            this.ReportCollection.Add(report);
        }
    }
}
