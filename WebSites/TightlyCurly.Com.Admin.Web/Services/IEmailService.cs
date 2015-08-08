using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TightlyCurly.Com.Admin.Web.Services
{
    // NOTE: If you change the interface name "IEmailService" here, you must also update the reference to "IEmailService" in Web.config.
    [ServiceContract]
    public interface IEmailService
    {
        [OperationContract]
        void DoWork();
    }
}
