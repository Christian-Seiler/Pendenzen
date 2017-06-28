using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Pendenzen.Update
{
    public partial class Updates : Form
    {
        String address = "http://update.christianseiler.ch/allpower_pendenzen.html";
        String data;
        bool uptodate = false;

        public Updates()
        {
            InitializeComponent();
            data = getData();
            setVersion();
            setHistory();
        }

        public void setVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            String current = fileVersionInfo.ProductVersion;
            String latest = getSubstring("VERSION");

            this.currentVersion.Text = $"Installiert: {current}";
            uptodate = (new Version(latest)).CompareTo(new Version(current)) > 0 ? false : true;
            availableVersion.Text = !uptodate ? $"Verfügbar: {latest}" : $"Die neuste Version ist installiert.";
        }

        public void setHistory()
        {
            historyText.Text = "<html>" + getSubstring("HISTORY") + "</html>";
        }

        public String setDownloadURL()
        {
            return getSubstring("URL");
        }

        private String getData()
        {
            String htmlCode = "";
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(address);
            }
            return htmlCode;
        }

        private String getSubstring(String key)
        {
            String keyStart = $"[{key.ToUpper()}]";
            String keyEnd = $"[/{key.ToUpper()}]";
            int startIndex = data.IndexOf(keyStart) + keyStart.Length;
            int length = data.IndexOf(keyEnd) - startIndex;
            return data.Substring(startIndex, length);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            String address = setDownloadURL();
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(address, "pendenzen.msi");
            }
        }
    }
}
