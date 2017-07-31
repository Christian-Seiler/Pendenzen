using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Pendenzen.Update
{
    public partial class Updates : Form
    {
        String address = "http://update.christianseiler.ch/update.php?id=allpower_pendenzen";
        String data;
        bool uptodate = false;
        String latest;
        String lastAvailable;
        String path;

        public Updates()
        {
            InitializeComponent();
            data = getData();
            setVersion();
            setHistory();
        }

        public bool supportIsValid()
        {
            switch (getSubstring("SUPPORT"))
            {
                case "valid":
                    return true;
                default:
                    return false;
            }
        }
        
        public void setVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            String current = fileVersionInfo.ProductVersion;
            latest = getSubstring("VERSION");
            lastAvailable = getSubstring("LATEST");

            this.currentVersion.Text = $"Installiert: {current}";

            bool newOutOfSupport = (new Version(latest)).CompareTo(new Version(lastAvailable)) < 0 ? true : false;
            if (newOutOfSupport)
            {
                availableVersion.Text = "Es ist eine neue Version verfügbar.\n Jetzt den Support verlängern.";
                downloadButton.Text = "Support verlängern";
            } else
            {
                uptodate = (new Version(latest)).CompareTo(new Version(current)) > 0 ? false : true;
                availableVersion.Text = !uptodate ? $"Verfügbar: {latest}" : $"Die neuste Version ist installiert.";
                if (uptodate)
                {
                    downloadButton.Enabled = false;
                }
            }
        }

        public void setHistory()
        {
            historyText.DocumentText = "<html>" + getSubstring("HISTORY") + "</html>";
        }

        public Uri setDownloadURL()
        {
            return new Uri(getSubstring("URL"));
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
            if (downloadButton.Text == "Download")
            {
                Uri address = setDownloadURL();
                using (WebClient client = new WebClient())
                {
                    downloadButton.Enabled = false;
                    path = $"{Path.GetTempPath()}/Pendenzen-{latest}.msi";
                    client.DownloadProgressChanged += downloadProgressChanged;
                    client.DownloadFileCompleted += downloadFileCompleted;
                    client.DownloadFileAsync(address, path);
                }
            } else if (downloadButton.Text == "Support verlängern")
            {
                String url = getSubstring("RENEW");
            } else if (downloadButton.Text == "Schliessen")
            {
                this.Close();
            }
        }

        private void downloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (startInstaller())
            {
                File.Open(path, FileMode.Open);
                sendStats();
                Application.Exit();
            }
            cleanUp();
        }

        private void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Double bytesIn = Double.Parse(e.BytesReceived.ToString());
            Double bytesTotal = Double.Parse(e.TotalBytesToReceive.ToString());
            progressBar.Value = e.ProgressPercentage;
        }

        private bool startInstaller()
        {
            DialogResult result = MessageBox.Show("Jetzt installieren?", "Update bereit", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void cleanUp()
        {
            downloadButton.Text = "Schliessen";
            downloadButton.Enabled = true;
            File.Delete(path);
        }

        private void sendStats()
        {
            String query = "SELECT AdminOption FROM admin WHERE idadmin = 'guid'";
            String guid = new DBConnect().Select(query).Rows[0].ItemArray[0].ToString();
            String app = "Pendenzen Updater";
            String version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
            String url = "http://update.christianseiler.ch/stats.php?id=" + guid + "&app=" + app + "&v=" + version;
            Debug.WriteLine(url);
            using (WebClient c = new WebClient())
            {
                c.DownloadString(url);
            }
        }
    }
}
