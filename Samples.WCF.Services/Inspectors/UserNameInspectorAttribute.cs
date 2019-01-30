using System;
using System.ServiceModel.Dispatcher;

namespace Samples.WCF.Services.Inspectors
{
    public class UserNameInspectorAttribute : Attribute, IParameterInspector
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            Console.Write("it was called");
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            var userNameValue = (string) inputs[0];
            if (string.IsNullOrWhiteSpace(userNameValue) || userNameValue.Length < 7)
            {
                throw new ArgumentException("userName", "Parameter is in the incorrect format.");
            }

            return null;

        }
    }
}
