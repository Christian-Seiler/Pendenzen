using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pendenzen
{
    class DatabaseRegistry
    {
        const String keyName = "Software\\Christian Seiler Services";
        private RegistryKey reg = Registry.LocalMachine;
        private String publicKey;



        public bool valuesAreSet()
        {
            bool isSet = true;

            if (getDatabase() == "") { isSet = false; }
            if (getLicenseKey() == "") { isSet = false; }
            if (getPassword() == "") { isSet = false; }
            if (getServer() == "") { isSet = false; }
            if (getUserID() == "") { isSet = false; }

            return isSet;
        }
        
        public void setDatabase(String database)
        {
            reg.SetValue(keyName + "\\database", database);
        }

        public String getDatabase()
        {
            return (string)reg.GetValue(keyName + "\\database");
        }

        public void setLicenseKey(String key)
        {
            reg.SetValue(keyName + "\\key", key);
        }

        public String getLicenseKey()
        {
            return (string)reg.GetValue(keyName + "\\key");
        }

        public void setPassword(String pass)
        {
            reg.SetValue(keyName + "\\password", pass);
        }

        public String getPassword()
        {
            return (string)reg.GetValue(keyName + "\\password");
        }

        public void setserver(String server)
        {
            reg.SetValue(keyName + "\\server", server);
        }

        public String getServer()
        {
            return (string)reg.GetValue(keyName + "\\server");
        }

        public void setUserID(String uid)
        {
            reg.SetValue(keyName + "\\uid", uid);
        }

        public String getUserID()
        {
            return (string)reg.GetValue(keyName + "\\uid");
        }
    }
}
