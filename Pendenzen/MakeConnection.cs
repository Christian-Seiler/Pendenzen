using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Pendenzen
{
    public class MakeConnection
    {
        public MakeConnection()
        {
            RegistryKey key;
            bool isSetup = true;

            key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Christian Seiler Services", true);

            Console.WriteLine(key.SubKeyCount + " Keys available");

            String license = key.GetValue("License").ToString();
            String server = key.GetValue("Server").ToString();
            String username = key.GetValue("Username").ToString();
            String database = key.GetValue("Database").ToString();
            String password = key.GetValue("Password").ToString();

            if (license == "" || server == "" || username == "" || database == "" || password == "")
            {
                isSetup = false;
            }
            if (isSetup)
            {
                DBConnect db = new DBConnect();
                if (db.Open())
                {
                    Application.Run(new mainForm());
                }
                else
                {
                    MessageBox.Show("Cannot connect to server. Please contact administrator");
                }
            }
            else
            {

            }
        }
    }
}