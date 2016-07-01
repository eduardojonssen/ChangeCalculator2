using ChangeCalculator.Core.DataContract;
using ChangeCalculator.Core.Log;
using ChangeCalculator.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core {

    public class CalculatorCore : ICalculatorCore {

        public CalculatorCore() {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calculatorChangeRequest"></param>
        /// <returns></returns>
        public CalculatorChangeResponse Calculator(CalculatorChangeRequest calculatorChangeRequest) {


            CalculatorChangeResponse calculatorChangeResponse = new CalculatorChangeResponse();

           // throw new OutOfMemoryException();
            
            long changeAmount = calculatorChangeRequest.ValuePayment - calculatorChangeRequest.SalePrice;
            long rest = changeAmount;

            List<ChangeResponse> changesResponse = new List<ChangeResponse>();

            while (rest > 0) {

                AbstractProcessor processor = ProcessorFactory.Create(rest);

                Dictionary<long, long> result = processor.Process(rest);

                if (result.Count > 0) {
                    //Adicionar dicionário
                    foreach (KeyValuePair<long, long> item in result) {
                        ChangeResponse change = new ChangeResponse(item.Key, item.Value, processor.Name);
                        changesResponse.Add(change);
                    }
                }
                rest = rest - result.Sum(x => x.Key * x.Value);
            }

            calculatorChangeResponse.SalePrice = calculatorChangeRequest.SalePrice;
            calculatorChangeResponse.ValuePayment = calculatorChangeRequest.ValuePayment;
            calculatorChangeResponse.ChangeAmount = changeAmount;

            calculatorChangeResponse.ChangeCollection = changesResponse;
            calculatorChangeResponse.Success = true;
            
            return calculatorChangeResponse;
        }

        public List<long> GetBillValues() {
            return new BillProcessor().AvailableValueCollection;
        }
    }
}
