using System;
using System.Reflection;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class issueForm : Form
    {
        public issueForm()
        {
            InitializeComponent();
            nameLabel.Text = "Name: " + person.getUserFullName() + " / " + person.getUserName();

            reloadData();
        }


        private void btnInfo_Click(object sender, System.EventArgs e)
        {
            // move to own window...
            DialogResult result = MessageBox.Show($"{ProductName}\n" +
            $"Version {ProductVersion} ({Assembly.GetExecutingAssembly().GetName().Version})\n" + 
             "Copyright © 2016 Christian Seiler Services. Alle Rechte vorbehalten.",
              "Info",
               MessageBoxButtons.OK);
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            addCompany add = new addCompany();
            add.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void addIssue_Click(object sender, EventArgs e)
        {
            addIssue add = new addIssue();
            add.ShowDialog();
        }

        public void reloadData()
        {
            DBConnect db = new DBConnect();
            string query = "SELECT * FROM pendenz WHERE state = 'open' ORDER BY idpendenz desc";
            issueDataView.DataSource = db.Select(query);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            reloadData();
        }
    }
}
