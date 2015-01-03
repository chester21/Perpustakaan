using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoFTLibrary.UI.ProviderServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISoFTLibrary" in both code and config file together.
    [ServiceContract]
    public interface ISoFTLibrary
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string SampleReturnString(string name);

        [OperationContract]
        int SampleReturnInt(int a);
    }
}
