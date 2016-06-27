using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract {

    public abstract class AbstractResponse {

        public AbstractResponse() {
            ReportCollection = new List<Report>();
        }

        internal void AddError(string field, string errorCode, string message) {

            Report report = new Report();

            report.ErrorCode = errorCode;
            report.Field = field;
            report.Message = message;

            this.ReportCollection.Add(report);
        }

        public List<Report> ReportCollection { get; set; }

        public bool Success { get; set; }
    }
}
