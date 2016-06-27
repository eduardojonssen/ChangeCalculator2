using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract {

    public sealed class CalculatorChangeRequest : AbstractRequest {

        public long SalePrice { get; set; }
        public long ValuePayment { get; set; }

        public CalculatorChangeRequest() : base() { }

        protected override void Validate() {

            if (SalePrice <= 0) {
                this.AddError("SalePrice", "001", "Por favor, informe um valor maior que zero.");
            }

            if (ValuePayment <= 0) {
                this.AddError("ValuePayment", "001", "Por favor, informe um valor maior que zero.");
            }

            if (ValuePayment < SalePrice) {
                this.AddError("ValuePayment", "001", "Não é possível inserir um valor de venda menor que o valor pago.");
            }
        }
    }
}
