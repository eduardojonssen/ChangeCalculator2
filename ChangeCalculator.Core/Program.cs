using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch {

	public class Change {

		public string Coin { get; private set; }
		public int Quantity { get; set; }

		public Change (string coin)
		{
			Coin = coin;
		}
	}

	public abstract class Counter {

		protected readonly decimal baseCalculate;
		public Change Change { get; protected set; }
		protected Counter CounterNext { get; set; }

		public Counter(string coin, decimal baseCalculate) {
			this.Change = new Change(coin);
			this.baseCalculate = baseCalculate;
		}

		public void setNext(Counter counter) {
			this.CounterNext = counter;
		}

		public virtual void processRequest(decimal value){

			if (value >= baseCalculate) {
				Change.Quantity = (int)(value / baseCalculate);
			}

			var rest = value % baseCalculate;
			if (value > 0 && this.CounterNext != null) {
				this.CounterNext.processRequest(rest);
			}
		}
	}

	public class OneRealCounter : Counter {

		public OneRealCounter() : base("1 Real", 1m) {

		}

		public override void processRequest(decimal value) {

			Change.Quantity = (int)Math.Abs(value);
			var rest = value % baseCalculate;

			if (rest > 0 && this.CounterNext != null) {
				this.CounterNext.processRequest(rest);
			}
		}
	}

	public class FifthCentsCounter : Counter {
		public FifthCentsCounter()
			: base("50 Cents", 0.5m) { }
		
	}

	public class TwentyFiveCentsCounter : Counter {

		public TwentyFiveCentsCounter()
			: base("25 Cents", 0.25m) { }
	}

	public class TenCentsCounter : Counter {

		public TenCentsCounter()
			: base("10 Cents", 0.10m) { }
	}

	public class FiveCentsCounter : Counter {

		public FiveCentsCounter()
			: base("5 Cents", 0.05m) { }
	}

	public class OneCentsCounter : Counter {

		public OneCentsCounter()
			: base("1 Cent", 0.01m) { }

		public override void processRequest(decimal value) {
			Change.Quantity = (int)(value * 100);
		}
	}

	public interface ICalculatorChange {
		ICollection<Change> Calculator(decimal salePrice, decimal valuePayment);
	}

	public class ManagerCalculator : ICalculatorChange {

		private List<Counter> CounterCollection { get; set; }
		private Counter Counter { get; set; }

		public ManagerCalculator() {

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

		public ICollection<Change> Calculator(decimal salePrice, decimal valuePayment) {

			var changeAmount = valuePayment - salePrice;
			Counter.processRequest(changeAmount);

			return CounterCollection.Where(x => x.Change.Quantity > 0).Select(x => x.Change).ToList();
		}
	}

	class Program {

		static void Main(string[] args) {

			ICalculatorChange calculatorChange = new ManagerCalculator();
			var changes = calculatorChange.Calculator(0m, 1.96m);


		}
	}
}
