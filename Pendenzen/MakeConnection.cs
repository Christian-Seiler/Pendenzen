using System;
using System.IO;
using System.Windows.Forms;
using System.Security;
using Pendenzen.Security;
using System.Net;
using System.Data;
using System.Reflection;
using System.Diagnostics;

namespace Pendenzen
{
    public class MakeConnection
    {
        public MakeConnection()
        {
            if (new DatabaseRegistry().valuesAreSet())
            {
                DBConnect db = new DBConnect();
                if (db.Open())
                {
                    String guid = db.Select(query).Rows[0].ItemArray[0].ToString();
                    String app = "Pendenzen";
                    String version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
                    String query = "SELECT AdminOption FROM admin WHERE idadmin = 'guid'";
                    String url = "http://update.christianseiler.ch/stats.php?id="+ guid + "&app=" + app + "&v=" + version;

                    using (WebClient c = new WebClient())
                    {
                        c.DownloadString(url);
                    }
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