using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.EnterpriseServices;

namespace ScpApiCom
{
    [JustInTimeActivation(true)]
    [EventTrackingEnabled(true)]
    public class Crypto : ServicedComponent
    {
        public string Encrypt(string sPath, string sKey, string sText)
        {
            string sReturn = "";

            try
            {
                ScpApiLib.ScpApi lib = new ScpApiLib.ScpApi();
                sReturn = lib.Encrypt(sPath, sKey, sText);
            }
            catch (Exception) { }

            return sReturn;
        }

        public string Decrypt(string sPath, string sKey, string sText)
        {
            string sReturn = "";

            try
            {
                ScpApiLib.ScpApi lib = new ScpApiLib.ScpApi();
                sReturn = lib.Decrypt(sPath, sKey, sText);
            }
            catch (Exception) { }

            return sReturn;
        }
    }
}
