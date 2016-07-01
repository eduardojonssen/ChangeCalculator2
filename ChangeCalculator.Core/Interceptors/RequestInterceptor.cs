using ChangeCalculator.Core.DataContract;
using ChangeCalculator.Core.Log;
using Dlp.Framework.Container.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.Interceptors {

    public class RequestInterceptor : IInterceptor {

        public void Intercept(IInvocation invocation) {

            LogManager.Write(invocation.Arguments.FirstOrDefault(), CategoryLog.Info);

            try {
                //if (invocation.MethodInvocationTarget.IsDefined(typeof()) == false) {
                
                AbstractRequest abstractRequest = invocation.Arguments.FirstOrDefault() as AbstractRequest;
                
                if (abstractRequest != null && abstractRequest.IsValid() == false) {
                    AbstractResponse abstractResponse = Activator.CreateInstance(invocation.ReturnType) as AbstractResponse;
                    abstractResponse.ReportCollection = abstractRequest.ReportCollection;
                    abstractResponse.Success = false;
                    invocation.ReturnValue = abstractResponse;
                    return; 
                }

                invocation.Proceed();
            }
            catch (Exception ex) {

                LogManager.Write(ex, CategoryLog.Error);

                AbstractResponse abstractResponse = Activator.CreateInstance(invocation.ReturnType) as AbstractResponse;

                abstractResponse.Success = false;
                abstractResponse.AddError(null, "ERROR", "Ocorreu um erro interno. Por favor, tente novamente mais tarde.");

                invocation.ReturnValue = abstractResponse;
            }
            finally {
                LogManager.Write(invocation.ReturnValue, CategoryLog.Info);
            }   
        }
    }
}
