using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class issueForm : Form
    {
        public Dictionary<string, string> dictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("ID", "idpendenz");
            dict.Add("Lieferant", "lieferant");
            dict.Add("Referenz-Nr.", "referenz");
            dict.Add("Dokument", "dokument");
            dict.Add("Erfasser", "erfasst_von");
            dict.Add("Sachbearbeiter", "sachbearbeiter");
            dict.Add("Status", "state");
            return dict;
        }

        public issueForm()
        {
            InitializeComponent();
            nameLabel.Text = "Name: " + person.getUserFullName() + " / " + person.getUserName();
            
            foreach (KeyValuePair<string, string> pair in dictionary())
            {
                searchDropBox.Items.Add(pair.Key);
            }

            reloadData();
        }

        private void btnInfo_Click(object sender, System.EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dictionary();

            var searchKey = "";

            dictionary().TryGetValue(searchDropBox.Text, out searchKey);

            
            DBConnect db = new DBConnect();
            string query = $"SELECT * FROM pendenz WHERE {searchKey} LIKE '{searchBox.Text}'";
            Console.WriteLine(query);
            issueDataView.DataSource = db.Select(query);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                addIssue issue = new addIssue();
                issue.ShowDialog();
            }
            if (tabControl.SelectedIndex == 1)
            {
                addCompany company = new addCompany();
                company.ShowDialog();
            }
        }

        public void reloadData()
        {
            //issueDataView.Enabled = true;
            DBConnect db = new DBConnect();
            string query = "SELECT * FROM pendenz WHERE state = 'open' ORDER BY idpendenz desc";
            issueDataView.DataSource = db.Select(query);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void issueDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string changeIssue = issueDataView.CurrentRow.Cells[0].Value.ToString();

            modifyIssue modify = new modifyIssue(int.Parse(changeIssue));
            modify.ShowDialog();
        }
    }
}
