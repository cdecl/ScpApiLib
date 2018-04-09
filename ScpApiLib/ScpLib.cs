using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScpApiLib
{
    static class ScpLib
    {
        [DllImport("scpdb_agent.dll", EntryPoint = "SCP_EncStr", CharSet = CharSet.Ansi)]
        public static extern int SCP_EncStr(
           string iniFilePath,
           string iniKeyName,
           string plain,
           int plainLen,
           byte[] cipher,
           ref int cipherLen,
           int cipherBufMax
        );

        [DllImport("scpdb_agent.dll", EntryPoint = "SCP_DecStr", CharSet = CharSet.Ansi)]
        public static extern int SCP_DecStr(
          string iniFilePath,
          string iniKeyName,
          string cipher,
          int cipherLen,
          byte[] plain,
          ref int plainLen,
          int plainBufMax
        );

        [DllImport("scpdb_agent.dll", EntryPoint = "SCP_EncB64", CharSet = CharSet.Ansi)]
        public static extern int SCP_EncB64(
           string iniFilePath,
           string iniKeyName,
           string plain,
           int plainLen,
           byte[] cipher,
           ref int cipherLen,
           int cipherBufMax
        );

        [DllImport("scpdb_agent.dll", EntryPoint = "SCP_DecB64", CharSet = CharSet.Ansi)]
        public static extern int SCP_DecB64(
          string iniFilePath,
          string iniKeyName,
          string cipher,
          int cipherLen,
          byte[] plain,
          ref int plainLen,
          int plainBufMax
        );

        [DllImport("scpdb_agent.dll", EntryPoint = "ScpAgt_Init", CharSet = CharSet.Ansi)]
        public static extern int
        ScpAgt_Init(string iniFilePath);

        [DllImport("scpdb_agent.dll", EntryPoint = "ScpAgt_ReInit", CharSet = CharSet.Ansi)]
        public static extern int
        ScpAgt_ReInit(string iniFilePath);

    }
}
