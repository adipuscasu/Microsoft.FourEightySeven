using System;
using System.ServiceModel.Configuration;
using Samples.WCF.Services.Inspectors;

namespace Samples.WCF.Services
{
    public class WcfMessageLoggerExtension : BehaviorExtensionElement
    {
        protected override object CreateBehavior()
        {
            return new WcfMessageLogger();
        }

        public override Type BehaviorType
        {
            get
            {
                return typeof(WcfMessageLogger);
            }
        }
    }
}
