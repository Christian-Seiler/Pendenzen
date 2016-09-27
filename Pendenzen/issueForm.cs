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

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            addCompany add = new addCompany();
            add.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dictionary();

            var searchKey = "";

            dictionary().TryGetValue(searchDropBox.Text, out searchKey);

            
            DBConnect db = new DBConnect();
            string query = $"SELECT * FROM pendenz WHERE {searchKey} LIKE {searchBox.Text}";
            issueDataView.DataSource = db.Select(query);
            Console.WriteLine(query);
        }

        private void addIssue_Click(object sender, EventArgs e)
        {
            addIssue add = new addIssue();
            add.ShowDialog();
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

        private void issueDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string changeIssue = issueDataView.CurrentRow.Cells[0].Value.ToString();

            modifyIssue modify = new modifyIssue(int.Parse(changeIssue));
            modify.ShowDialog();
        }
    }
}
