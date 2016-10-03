using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace Pendenzen
{
    public partial class issueForm : Form
    {
        DBConnect db = new DBConnect();
        addIssue issue = new addIssue();
        addCompany company = new addCompany();


        public Dictionary<string, string> dictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (tabControl.SelectedIndex == 0)
            {
                dict.Add("ID", "idpendenz");
                dict.Add("Lieferant", "lieferant");
                dict.Add("Referenz-Nr.", "referenz");
                dict.Add("Dokument", "dokument");
                dict.Add("Erfasser", "erfasst_von");
                dict.Add("Sachbearbeiter", "sachbearbeiter");
                dict.Add("Status", "state");
            }
            if (tabControl.SelectedIndex == 1)
            {
                dict.Add("Kürzel", "company_id");
                dict.Add("Lieferant", "company_name");
                dict.Add("PLZ", "company_plz");
                dict.Add("City", "company_city");
                dict.Add("Land", "company_country");

                getCompanyIndex();
            }

            return dict;
            
        }

        private void getCompanyIndex()
        {
            
            DataTable table = db.Select("SELECT company_id FROM company");

            ArrayList companies = new ArrayList(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                companies.Add(row.ItemArray[0]);
            }
            int currentID = companies.IndexOf(idLabel.Text) + 1;
            countLabel.Text = $"{currentID} von {db.Count("SELECT Count(*) FROM company")}";
        }

        public issueForm()
        {
            InitializeComponent();
            nameLabel.Text = "Name: " + person.getUserFullName() + " / " + person.getUserName();

            tabControl_Selected(null, null);
            reloadData();
        }

        private void reloadData()
        {
            //issueDataView.Enabled = true;
            DBConnect db = new DBConnect();
            string query = "SELECT * FROM pendenz WHERE state = 'open' ORDER BY idpendenz desc";
            issueDataView.DataSource = db.Select(query);
        }

        private void loadContact(string id)
        {
            DataTable table = db.Select($"SELECT * FROM company WHERE company_id = '{id}'");

            ArrayList contact = new ArrayList(table.Columns.Count);
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    contact.Add(row[column]);
                }
            }

            idLabel.Text = contact[0].ToString();
            companyLabel.Text = contact[1].ToString();
            streetLabel.Text = contact[2].ToString();
            poBoxLabel.Text = contact[3].ToString();
            plzLabel.Text = contact[4].ToString();
            cityLabel.Text = contact[5].ToString();
            countryLabel.Text = contact[6].ToString();
            phoneLabel.Text = contact[7].ToString();
            urlLabel.Text = contact[8].ToString();
            emailVerkaufLabel.Text = contact[9].ToString();
            emailEinkaufLabel.Text = contact[10].ToString();
            verkaufKontaktLabel.Text = $"Verkauf: {contact[11].ToString()}";
            einkaufKontaktLabel.Text = $"Einkauf: {contact[12].ToString()}";
            verkaufBusproLabel.Text = $"Verkauf: {contact[13].ToString()}";
            einkaufBusproLabel.Text = $"Einkauf: {contact[14].ToString()}";
            kundeLabel.Text = $" Kunde seit: {contact[15].ToString()}";
        }

        #region UIControls
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

            if (tabControl.SelectedIndex == 0)
            {
                string query = $"SELECT * FROM pendenz WHERE {searchKey} LIKE '{searchBox.Text}'";
                issueDataView.DataSource = db.Select(query);
            }
            if (tabControl.SelectedIndex == 1)
            {

            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                issue.ShowDialog();
            }
            if (tabControl.SelectedIndex == 1)
            {
                company.ShowDialog();
            }
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

        private void neuePendenzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addIssue issue = new addIssue();
            issue.ShowDialog();
        }

        private void neueAdresseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCompany company = new addCompany();
            company.ShowDialog();
        }

        private void schliessenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {

            if (tabControl.SelectedIndex == 1)
            {
                loadContact(idLabel.Text);
            }
            searchDropBox.Items.Clear();
            foreach (KeyValuePair<string, string> pair in dictionary())
            {
                searchDropBox.Items.Add(pair.Key);
            }
        }

        private void openLinkButton_Click(object sender, EventArgs e)
        {
            Process.Start(urlLabel.Text);
        }

        private void companyChangeLabel_Click(object sender, EventArgs e)
        {
            modifyCompany modifyCompany = new modifyCompany(idLabel.Text);
            modifyCompany.ShowDialog();
        }
        #endregion

    }
}