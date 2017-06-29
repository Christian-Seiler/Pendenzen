﻿using System;
using System.Diagnostics;
using System.IO;
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
        String latest;
        String path;

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
            latest = getSubstring("VERSION");

            this.currentVersion.Text = $"Installiert: {current}";
            uptodate = (new Version(latest)).CompareTo(new Version(current)) > 0 ? false : true;
            availableVersion.Text = !uptodate ? $"Verfügbar: {latest}" : $"Die neuste Version ist installiert.";
            if (uptodate)
            {
                downloadButton.Enabled = false;
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
            }
            if (downloadButton.Text == "Schliessen")
            {
                this.Close();
            }
        }

        private void downloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (startInstaller())
            {
                File.Open(path, FileMode.Open);
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
    }
}
