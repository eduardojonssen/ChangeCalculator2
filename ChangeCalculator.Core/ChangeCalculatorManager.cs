using ChangeCalculator.Core.DataContract;
using ChangeCalculator.Core.Interface;
using ChangeCalculator.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core {
    public class ChangeCalculatorManager : IChangeCalculator {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calculatorChangeRequest"></param>
        /// <returns></returns>
        public CalculatorChangeResponse Calculator(CalculatorChangeRequest calculatorChangeRequest) {
            CalculatorChangeResponse calculatorChangeResponse = new CalculatorChangeResponse();

            try {


                if (calculatorChangeRequest.IsValid() == false) {
                    calculatorChangeResponse.ReportCollection = calculatorChangeRequest.ReportCollection;
                    calculatorChangeResponse.Success = false;
                    return calculatorChangeResponse;
                }
                
                calculatorChangeResponse.SalePrice = calculatorChangeRequest.SalePrice;
                calculatorChangeResponse.ValuePayment = calculatorChangeRequest.ValuePayment;
                calculatorChangeResponse.ChangeAmount = calculatorChangeRequest.ValuePayment - calculatorChangeRequest.SalePrice;

                long rest = calculatorChangeResponse.ChangeAmount;

                List<ChangeResponse> changesResponse = new List<ChangeResponse>();

                while (rest>0) {

                    AbstractProcessor processor = ProcessorFactory.Create(rest);

                    Dictionary<long,long> result = processor.Process(rest);

                    if(result.Count>0) {
                        //Adicionar dicionário
                        foreach (KeyValuePair<long,long> item in result) {
                            ChangeResponse change = new ChangeResponse(item.Key, item.Value, processor.Name);
                            changesResponse.Add(change);
                        }
                    }
                    rest = rest - result.Sum(x => x.Key * x.Value);
                }
                
                calculatorChangeResponse.ChangeCollection = changesResponse;
                calculatorChangeResponse.Success = true;
            }
            catch (Exception ex) {
                calculatorChangeResponse.Success = false;
                calculatorChangeResponse.AddError(null, "ERROR", "Ocorreu um erro interno. Por favor, tente novamente mais tarde.");
            }

            return calculatorChangeResponse;
        }
    }
}
