using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public sealed class CalculatorChangeRequest : AbstractRequest
    {
        public long SalePrice { get; set; }
        public long ValuePayment { get; set; }
        
        public CalculatorChangeRequest() {
            MessageCollection = new Dictionary<string,IList<string>>();
        }

        public override bool IsValid() {
            
            if (SalePrice <= 0) {

                List<string> errorMessageCollection = new List<string>();

                errorMessageCollection.Add("Por favor, informe um valor maior que zero.");

                MessageCollection.Add("SalePrice", errorMessageCollection);
            }

            if (ValuePayment <= 0) {

                List<string> errorMessageCollection = new List<string>();

                errorMessageCollection.Add("Por favor, informe um valor maior que zero.");
                MessageCollection.Add("ValuePayment", errorMessageCollection);
            }

            if (ValuePayment<SalePrice) {
                List<string> errorMessageCollection = new List<string>();

                errorMessageCollection.Add("Não é possível inserir um valor de venda menor que o valor pago.");
                MessageCollection.Add("InvalidOperation", errorMessageCollection);
            }

            bool isValid = (MessageCollection.Any() == false);
            
            return isValid;
        }
    }
}
