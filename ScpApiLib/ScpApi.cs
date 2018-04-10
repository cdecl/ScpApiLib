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
        const string DEFAULT_CHARSET = "euc-kr";
        private Encoding DefaultEncode = Encoding.GetEncoding(DEFAULT_CHARSET);

        private delegate int CryptoFuncType (
           string iniFilePath,
           string iniKeyName,
           string plain,
           int plainLen,
           byte[] cipher,
           ref int cipherLen,
           int cipherBufMax
        );

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
            string sReturn = "";

            try
            {
                int nInBytes = DefaultEncode.GetByteCount(sText);
                int nOutBytes = GetBuffSize(nInBytes);

                byte[] byteOut = new byte[nOutBytes];
                int nOutLen = 0;

                int ret = Crypto(sPath, sKey, sText, nInBytes, byteOut, ref nOutLen, nOutBytes);
                if (ret != 0) throw new Exception(string.Format("SCP API ({0})", ret));

                sReturn = DefaultEncode.GetString(byteOut, 0, nOutLen);
#if DEBUG
                Trace.WriteLine(string.Format("ScpApiLib In: {0}, Out: {1}, Calc: {2}", nInBytes, nOutLen, nOutBytes));
#endif 
            }
            catch (Exception ex) {
                Trace.WriteLine(string.Format("ScpApiLib Exception : {0}", ex.Message));
            }

            return sReturn;
        }

        private int GetBuffSize(int nInput)
        {
            const int MAX_BUFF_SIZE = 8192;
            int nSize = MAX_BUFF_SIZE;

            if (nInput < 64 ) nSize = 128;
            else if (nInput < 128) nSize = 256;
            else if (nInput < 256) nSize = 512;
            else if (nInput < 512) nSize = 1024;
            else if (nInput < 1024) nSize = 2048;
            else if (nInput < 2048) nSize = 4096;

            return nSize;
        }

    }
}
    