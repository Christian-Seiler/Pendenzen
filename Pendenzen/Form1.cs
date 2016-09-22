using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NameLabel.Text = "Name: " + person.getUserFullName() + " / " + person.getUserName();
        }

        

        private void btnInfo_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Copyright (c) 2016 Christian Seiler Services", "Info", MessageBoxButtons.OK);
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            addCompany add = new addCompany();
            add.ShowDialog();
        }
    }
}
