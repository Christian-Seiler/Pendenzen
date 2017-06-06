using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();

            productNameLabel.Text = ProductName;
            versionLabel.Text = $"Version {ProductVersion}";
            String year = $"2016 - {DateTime.Now.Year}";
            copyrightLabel.Text = $"Copyright © {year} Christian Seiler Services.\n" +
                                  "Alle Rechte vorbehalten.";
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            open("http://www.christianseiler.ch");
        }

        private void bugButton_Click(object sender, EventArgs e)
        {
            open("http://support.christianseiler.ch/open.php");
        }

        private void featureButton_Click(object sender, EventArgs e)
        {
            open("http://voice.christianseiler.ch/");
            
        }

        private void open(String url)
        {
            Process.Start(url);
        }
    }
}