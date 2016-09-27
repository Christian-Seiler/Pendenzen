using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();

            productNameLabel.Text = ProductName;
            versionLabel.Text = $"Version {ProductVersion} ({System.Reflection.Assembly.GetExecutingAssembly().GetName().Version})";
            copyrightLabel.Text = "Copyright © 2016 Christian Seiler Services.\n" +
                "Alle Rechte vorbehalten.";
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            string url = "http://www.christianseiler.ch";

            System.Diagnostics.Process.Start(url);
        }
    }
}
