using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoFTLibrary.UI.ProviderServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SoFTLibrary" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SoFTLibrary.svc or SoFTLibrary.svc.cs at the Solution Explorer and start debugging.
    public class SoFTLibrary : ISoFTLibrary
    {
        public void DoWork()
        {
        }

        public string SampleReturnString(string name)
        {
            return "Kamu menulis kata : " + name;
        }

        public int SampleReturnInt(int a)
        {
            return a*175;
        }
    }
}
