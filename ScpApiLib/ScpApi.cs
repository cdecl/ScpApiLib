using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ScpApiLib
{
    public class ScpApi
    {
        const int BUFF_SIZE = 2048;
        const string DEFAULT_CHARSET = "euc-kr";

        private delegate int CryptoFuncType (
           string iniFilePath,
           string iniKeyName,
           string plain,
           int plainLen,
           byte[] cipher,
           ref int cipherLen,
           int cipherBufMax
        );

        Encoding DefaultEncode = Encoding.GetEncoding(DEFAULT_CHARSET);

        public string Encrypt(string sPath, string sKey, string sText)
        {
            return CryptFunc(ScpLib.SCP_EncB64, sPath, sKey, sText);
        }

        public string Decrypt(string sPath, string sKey, string sText)
        {
            return CryptFunc(ScpLib.SCP_DecB64, sPath, sKey, sText);
        }

        private string CryptFunc(CryptoFuncType Crypto, string sPath, string sKey, string sText)
        {
            byte[] byteOut = new byte[BUFF_SIZE];
            int nOutLen = 0;
            string sReturn = "";

            try
            {
                int ret = Crypto(sPath, sKey, sText, DefaultEncode.GetByteCount(sText), byteOut, ref nOutLen, BUFF_SIZE);
                if (ret != 0) throw new Exception("SCP API Error");

                sReturn = DefaultEncode.GetString(byteOut, 0, nOutLen);
            }
            catch (Exception ex) {
                Trace.WriteLine(string.Format("ScpApiLib Exception : {0}", ex.Message));
            }

            return sReturn;
        }

    }
}
    