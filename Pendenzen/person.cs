using Microsoft.Win32;
using System;
using System.Linq;

namespace Pendenzen
{
    public class person
    {
        public static string getUserName()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
        }

        public static string getUserFullName()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Office\Common\UserInfo");
            return key.GetValue("UserName").ToString();
        }
    }
}