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

            CounterCollection = new List<Counter>{
                new Counter("100 Reais", 10000),
                new Counter("50 Reais", 5000),
                new Counter("20 Reais", 2000),
                new Counter("10 Reais", 1000),
                new Counter("5 Reais", 500),
                new Counter("2 Reais", 200),
                new Counter("1 Real", 100),
                new Counter("50 cents", 50),
                new Counter("25 cents", 25),
                new Counter("10 cents", 10),
                new Counter("5 cents", 5),
                new Counter("1 cent", 1)
            };


            for (int i = 0; i < CounterCollection.Count-1; i++) {
                CounterCollection[i].setNext(CounterCollection[i + 1]);
            }  
            
            
            //        moeda.setNext(moeda);


            //oneRealCounter.setNext(fifthCentsCounter);
            //fifthCentsCounter.setNext(twentyFiveCentsCounter);
            //twentyFiveCentsCounter.setNext(tenCentsCounter);
            //tenCentsCounter.setNext(fiveCentsCounter);
            //fiveCentsCounter.setNext(oneCentsCounter);

            //CounterCollection = new List<Counter>{
            //    oneRealCounter,
            //    fifthCentsCounter,
            //    twentyFiveCentsCounter,
            //    tenCentsCounter,
            //    fiveCentsCounter,
            //    oneCentsCounter
            //};

            Counter = CounterCollection.First();
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
                    calculatorChangeResponse.ReportCollection = calculatorChangeRequest.ReportCollection;
                    calculatorChangeResponse.Success = false;
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
