using ChangeCalculator.Core.DataContract;
using ChangeCalculator.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core
{
    public class ChangeCalculatorManager : IChangeCalculator
    {

        private List<Counter> CounterCollection { get; set; }
        private Counter Counter { get; set; }

        public ChangeCalculatorManager()
        {

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

        public CalculatorChangeResponse Calculator(CalculatorChangeRequest calculatorChangeRequest)
        {
            CalculatorChangeResponse calculatorChangeResponse = new CalculatorChangeResponse
            {
                Success = true
            };

            try
            {
                calculatorChangeResponse.Code = "SUCCESS001";
                

                calculatorChangeResponse.SalePrice = calculatorChangeRequest.SalePrice;
                calculatorChangeResponse.ValuePayment = calculatorChangeRequest.ValuePayment;
                calculatorChangeResponse.ChangeAmount = calculatorChangeRequest.ValuePayment - calculatorChangeRequest.SalePrice;


                Counter.Process(calculatorChangeResponse.ChangeAmount);

                calculatorChangeResponse.ChangeCollection =
                    CounterCollection.Where(x => x.Change.Quantity > 0)
                        .Select(x => new ChangeResponse(x.Change.Coin, x.Change.Quantity))
                        .ToList();

                calculatorChangeResponse.MessageCollection.Add(new MessageRequest("", new List<string> { "Process with success" }));
            }
            catch (Exception ex)
            {
                calculatorChangeResponse.Success = false;
                calculatorChangeResponse.Code = "ERROR001";
                calculatorChangeResponse.MessageCollection.Add(new MessageRequest("", new List<string> { ex.Message }));
            }

            return calculatorChangeResponse;
        }
    }
}
