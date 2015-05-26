using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    [ServiceContract]
    public interface IEmailValidator
    {        
        [OperationContract]
        bool ValiddateAdress(string emailAddress);
    }
}
