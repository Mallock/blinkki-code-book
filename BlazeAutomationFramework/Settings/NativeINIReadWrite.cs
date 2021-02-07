using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlazeAutomationFramework.Settings
{
    public class NativeINIReadWrite
    {
        [DllImport("kernel32")]
        private static extern Int32 WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);


        public string INIRead(string INIPath, string SectionName, string KeyName, string DefaultValue)
        {
            string INIReadRet = "";
            

            byte[] buffer = new byte[2048];

            GetPrivateProfileSection(SectionName, buffer, 2048, INIPath);
            String[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');

            List<IniValue> result = new List<IniValue> { };

            foreach (String entry in tmp)
            {
                if (entry != "")
                {
                    IniValue iVal = new IniValue();
                    iVal.keyName = entry.Substring(0, entry.IndexOf("="));
                    iVal.keyValue = entry.Substring(entry.IndexOf("=") + 1);
                    result.Add(iVal);
                }
            }
            if(result.Count > 0)
            {
                IniValue iniValue = result.FirstOrDefault(e => e.keyName == KeyName);
                if (iniValue != null) { INIReadRet = iniValue.keyValue; }
            }
           
            return INIReadRet;
        }

        public string INIRead(string INIPath, string SectionName, string KeyName)
        {
            // overload 1 assumes zero-length default
            return INIRead(INIPath, SectionName, KeyName, "");
        }

        public string INIRead(string INIPath, string SectionName)
        {
            // overload 2 returns all keys in a given section of the given file
            return INIRead(INIPath, SectionName, default, "");
        }

        public string INIRead(string INIPath)
        {
            // overload 3 returns all section names given just path
            return INIRead(INIPath, default, default, "");
        }

        public void INIWrite(string INIPath, string SectionName, string KeyName, string TheValue)
        {
            WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath);
        }

        public void INIDelete(string INIPath, string SectionName, string KeyName)
        // delete single line from section
        {
            WritePrivateProfileString(SectionName, KeyName, default, INIPath);
        }

        public void INIDelete(string INIPath, string SectionName)
        {
            // delete section from INI file
            WritePrivateProfileString(SectionName, default, default, INIPath);
        }
    }
}
