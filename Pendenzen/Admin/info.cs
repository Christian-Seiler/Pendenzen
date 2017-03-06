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
            var url = "http://www.christianseiler.ch";

            Process.Start(url);
        }

        private void bugButton_Click(object sender, EventArgs e)
        {
            var url = "https://github.com/Christian-Seiler/Pendenzen/issues/new";

            Process.Start(url);
        }
    }
}