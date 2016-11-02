using System.Linq;
using System.Security.Principal;
using Microsoft.Win32;

namespace Pendenzen
{
    public class person
    {
        public static string getUserName()
        {
            return WindowsIdentity.GetCurrent().Name.Split('\\').Last();
        }

        public static string getUserFullName()
        {
            var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Office\Common\UserInfo");
            return key.GetValue("UserName").ToString();
        }
    }
}