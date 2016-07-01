using ChangeCalculator.Core.DataContract;
using ChangeCalculator.Core.Interceptors;
using ChangeCalculator.Core.Interface;
using ChangeCalculator.Core.Log;
using ChangeCalculator.Core.Processors;
using Dlp.Framework.Container;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core {

    public class ChangeCalculatorManager : IChangeCalculator {

        public ChangeCalculatorManager() {

            IocFactory.Register(
                    Component.For<ICalculatorCore>().Interceptor<RequestInterceptor>()
                        .ImplementedBy<CalculatorCore>().IsSingleton()
                );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calculatorChangeRequest"></param>
        /// <returns></returns>
        public CalculatorChangeResponse Calculator(CalculatorChangeRequest calculatorChangeRequest) {

            ICalculatorCore calculatorCore = IocFactory.Resolve<ICalculatorCore>();

            return calculatorCore.Calculator(calculatorChangeRequest);
        }

        public List<long> GetBillValues() {
            return IocFactory.Resolve<ICalculatorCore>().GetBillValues();
        }
    }
}
