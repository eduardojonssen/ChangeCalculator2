using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract {

    public sealed class Report {

        public Report() { }

        public string Field { get; set; }

        public string ErrorCode { get; set; }

        public string Message { get; set; }
    }
}
