using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Updater
{
    public static class StaticClasses
    {
        private static string installPath = string.Empty;

        public static string InstallPath
        {
            get
            {
                if (installPath == string.Empty)
                {
                    if (8 == IntPtr.Size ||
                        (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
                    {
                        installPath = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
                        if (installPath == null)
                        {
                            installPath = "C:\\Program Files (x86)";
                        }
                    }
                    else
                    {
                        installPath = Environment.GetEnvironmentVariable("ProgramFiles");
                        if (installPath == null)
                        {
                            installPath = "C:\\Program Files";
                        }
                    }
                    installPath = Path.GetPathRoot(installPath) + Updater.Default.CompanyName + "\\";
                }
                return installPath;
            }
        }

        public static string getStringArrayValuesAsString(string[] stringArray, string separator, bool omitEmptyGuid)
        {
            StringBuilder builder = new StringBuilder();
            bool hasEmtpyGuid = false;
            foreach (string s in stringArray)
            {
                if (s == Guid.Empty.ToString())
                {
                    
                }
            }
        }
    }
}
