using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MathService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMathService" in both code and config file together.
    [ServiceContract]
    public interface IIdPasswordSOAP
    {
        [OperationContract]
        string passwordCreate(string firstName, string lastName, int age);
        [OperationContract]
        int loginId(int age);

    }
}
