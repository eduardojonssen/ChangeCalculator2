using ChangeCalculator.Core.DataContract;
using ChangeCalculator.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core {
    public class ChangeCalculatorManager : IChangeCalculator {

        private List<Counter> CounterCollection { get; set; }
        private Counter Counter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ChangeCalculatorManager() {

            var oneRealCounter = new OneRealCounter();
            var fifthCentsCounter = new FifthCentsCounter();
            var twentyFiveCentsCounter = new TwentyFiveCentsCounter();
            var tenCentsCounter = new TenCentsCounter();
            var fiveCentsCounter = new FiveCentsCounter();
            var oneCentsCounter = new OneCentsCounter();

            oneRealCounter.setNext(fifthCentsCounter);
            fifthCentsCounter.setNext(twentyFiveCentsCounter);
            twentyFiveCentsCounter.setNext(tenCentsCounter);
            tenCentsCounter.setNext(fiveCentsCounter);
            fiveCentsCounter.setNext(oneCentsCounter);

            CounterCollection = new List<Counter>{
                oneRealCounter,
                fifthCentsCounter,
                twentyFiveCentsCounter,
                tenCentsCounter,
                fiveCentsCounter,
                oneCentsCounter
            };

            Counter = oneRealCounter;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="calculatorChangeRequest"></param>
        /// <returns></returns>
        public CalculatorChangeResponse Calculator(CalculatorChangeRequest calculatorChangeRequest) {
            CalculatorChangeResponse calculatorChangeResponse = new CalculatorChangeResponse();

            try {


                if (calculatorChangeRequest.IsValid() == false) {

                    calculatorChangeResponse.MessageCollection = calculatorChangeRequest.MessageCollection;

                    calculatorChangeResponse.Success = false;
                    calculatorChangeResponse.Code = "ERROR001";

                    return calculatorChangeResponse;
                }
                
                calculatorChangeResponse.SalePrice = calculatorChangeRequest.SalePrice;
                calculatorChangeResponse.ValuePayment = calculatorChangeRequest.ValuePayment;
                calculatorChangeResponse.ChangeAmount = calculatorChangeRequest.ValuePayment - calculatorChangeRequest.SalePrice;

                Counter.Process(calculatorChangeResponse.ChangeAmount);

                calculatorChangeResponse.ChangeCollection =
                    CounterCollection.Where(x => x.Change.Quantity > 0)
                        .Select(x => new ChangeResponse(x.Change.Coin, x.Change.Quantity))
                        .ToList();

                                
                calculatorChangeResponse.Code = "SUCCESS001";
                calculatorChangeResponse.Success = true;
            }
            catch (Exception ex) {
                calculatorChangeResponse.Success = false;
                calculatorChangeResponse.Code = "ERROR001";

                List<string> errorMessageCollection = new List<string>();

                errorMessageCollection.Add("Ocorreu um erro interno. Por favor, tente novamente mais tarde.");

                calculatorChangeResponse.MessageCollection.Add("ERROR",errorMessageCollection);
            }

            return calculatorChangeResponse;
        }
    }
}
