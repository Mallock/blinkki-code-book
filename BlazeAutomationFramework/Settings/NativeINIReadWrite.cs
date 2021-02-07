using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazeAutomationFramework.Settings
{
    public class NativeINIReadWrite
    {
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern Int32 WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern Int32 GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, string lpReturnedString, Int32 nSize, string lpFileName);
        public string INIRead(string INIPath, string SectionName, string KeyName, string DefaultValue)
        {
            string INIReadRet = default;
            // primary version of call gets single value given all parameters
            int n;
            string sData;
            sData = Strings.Space(1024); // allocate some room
            n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, sData, sData.Length, INIPath);
            if (n > 0) // return whatever it gave us
            {
                INIReadRet = sData.Substring(0, n);
            }
            else
            {
                INIReadRet = "";
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
