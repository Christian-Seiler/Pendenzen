using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.Text;
using System.IO;
using System.Threading;
using System.Drawing.Printing;
using System.Drawing;

namespace Pendenzen
{
    public partial class issueForm : Form
    {
        DBConnect db = new DBConnect();
        addIssue issue = new addIssue();
        addCompany company = new addCompany();
        ArrayList _companies;
        DataTable _table;
        string query;
        StringFormat strFormat;
        int iCellHeight;
        int iCount;
        bool bFirstPage;
        bool bNewPage;


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

            _companies = new ArrayList(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                _companies.Add(row.ItemArray[0]);
            }
            
            int currentID = _companies.IndexOf(idLabel.Text) + 1;
            countLabel.Text = $"{currentID} von {_companies.Count}";

            if (currentID == 1)
            {
                previousButton.Enabled = false;
            }
            else
            {
                previousButton.Enabled = true;
            }
            if (currentID == _companies.Count) 
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }

        public issueForm()
        {
            InitializeComponent();
            nameLabel.Text = "Name: " + person.getUserFullName() + " / " + person.getUserName();

            tabControl_Selected(null, null);
            
            threadStarter();
        }

        private void reloadData(int tabIndex)
        {
            if (tabIndex == 0)
            {
                loadIssues();
            }
            else if (tabIndex == 1)
            {
                loadContact(idLabel.Text);
            }
        }

        private void loadIssues()
        {
            query = "SELECT * FROM pendenz WHERE state = 'open' ORDER BY idpendenz desc";
            issueDataView.DataSource = db.Select(query);
        }

        private void loadContact(string id)
        {
            _table = db.Select($"SELECT * FROM company WHERE company_id = '{id}'");
            makeData(_table);
        }

        private void loadContact(string searchKey, string id)
        {
            _table = db.Select($"SELECT * FROM company WHERE {searchKey} = '{id}'");

            makeData(_table);
        }
        
        private void makeData(DataTable table)
        {
            ArrayList contact = new ArrayList(table.Columns.Count);
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    contact.Add(row[column]);
                }
            }

            kundeLabel.Text = "";
            einkauferLabel.Text = "";

            DateTime kundeDate;
            if (contact[15].ToString() != "")
            {
                kundeDate = DateTime.Parse(contact[15].ToString());
                string date = kundeDate.ToShortDateString();
                kundeLabel.Text = $" Kunde seit: {date}";
            }
            DateTime einkaufDate;
            if (contact[16].ToString() != "")
            {
                einkaufDate = DateTime.Parse(contact[16].ToString());
                string date = einkaufDate.ToShortDateString();
                einkauferLabel.Text = $" Verkauf seit: {date}";
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
            historyBox.Text = contact[17].ToString();
            getCompanyIndex();
            manageButtons();
        }

        private void manageButtons()
        {
            if (urlLabel.Text == "")
            {
                openLinkButton.Visible = false;
                webLabel.Visible = false;
            } else
            {
                openLinkButton.Visible = true;
                webLabel.Visible = true;
            }
            if (emailVerkaufLabel.Text == "")
            {
                verkaufEmailButton.Visible = false;
                verkaufLabel.Visible = false;
            } else
            {
                verkaufEmailButton.Visible = true;
                verkaufLabel.Visible = true;
            }
            if (emailEinkaufLabel.Text == "")
            {
                einkaufEmailButton.Visible = false;
                einkaufLabel.Visible = false;
            } else
            {
                einkaufEmailButton.Visible = true;
                einkaufLabel.Visible = true;
            }
        }

        private void WriteToCSV()
        {
            query = createQuery("company");
            DataTable table = db.Select(query);
            var result = new StringBuilder();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                result.Append(table.Columns[i].ColumnName);
                result.Append(i == table.Columns.Count - 1 ? "\n" : ",");
            }

            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    result.Append(row[i].ToString());
                    result.Append(i == table.Columns.Count - 1 ? "\n" : ",");
                }
            }
            
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "export.csv";
            saveFile.DefaultExt = "csv";
            saveFile.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE");
            saveFile.Title = "Adressen exportieren unter";
            saveFile.Filter = "Alle Dateien (*.*)|*.*";
            saveFile.CheckPathExists = true;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string path = saveFile.FileName;
                File.WriteAllText(path, result.ToString(), Encoding.Unicode);
            }
        }

        private string createQuery(string table)
        {
            return $"SELECT * FROM {table}";
        }

        private string createQuery(string table, string searchKey)
        {
            return $"SELECT * FROM {table} WHERE {searchKey} = ''";
        }

        private string createQuery(string table, string searchKey, string searchText)
        {
            return $"SELECT * FROM {table} WHERE {searchKey} LIKE '{searchText}'";
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

                if (searchBox.Text != "")
                {
                    query = createQuery("pendenz", searchKey, searchBox.Text);
                }
                else if (searchBox.Text == "")
                {
                    query = createQuery("pendenz", searchKey);
                }
                issueDataView.DataSource = db.Select(query);

            }
            if (tabControl.SelectedIndex == 1)
            {
                loadContact(searchKey, searchBox.Text);
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
            reloadData(tabControl.SelectedIndex);
        }

        private void issueDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string changeIssue = issueDataView.CurrentRow.Cells[0].Value.ToString();

            modifyIssue modify = new modifyIssue(int.Parse(changeIssue));
            modify.ShowDialog();
        }

        private void neuePendenzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issue.ShowDialog();
        }

        private void neueAdresseToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            reloadData(tabControl.SelectedIndex);

            searchDropBox.Items.Clear();
            foreach (KeyValuePair<string, string> pair in dictionary())
            {
                searchDropBox.Items.Add(pair.Key);
            }
        }

        private void openLinkButton_Click(object sender, EventArgs e)
        {
            if (urlLabel.Text != "")
            {
                Process.Start(urlLabel.Text);
            }
        }

        private void companyChangeLabel_Click(object sender, EventArgs e)
        {
            modifyCompany modifyCompany = new modifyCompany(idLabel.Text);

            modifyCompany.ShowDialog();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            int id = _companies.IndexOf(idLabel.Text);
            if (id > 0)
            {
                string previousID = _companies[id - 1].ToString();
                loadContact(previousID);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int id = _companies.IndexOf(idLabel.Text) + 1;
            string nextID = _companies[id].ToString();
            loadContact(nextID);
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            WriteToCSV();
        }

        private void verkaufEmailButton_Click(object sender, EventArgs e)
        {
            Process.Start($"mailto:{emailVerkaufLabel.Text}");
        }

        private void einkaufEmailButton_Click(object sender, EventArgs e)
        {
            Process.Start($"mailto:{emailEinkaufLabel.Text}");
        }
        #endregion

        #region MultiThreading
        private void threadStarter()
        {
            Thread thread = new Thread(new ThreadStart(this.threadTask));
            thread.IsBackground = true;
            thread.Start();
        }

        private void threadTask()
        {
            while (true)
            {
                Thread.Sleep(1000);
                this.Invoke((MethodInvoker)delegate { reloadData(tabControl.SelectedIndex); });
            }
        }
        #endregion

        private void druckenButton_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM pendenz GROUP BY sachbearbeiter;";
            issueDataView.DataSource = db.Select(query);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Pendenzen";
                printDocument1.Print();
            }
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidth.Clear();
                iCellHeight = 0;
                iCount = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn gridColumn in issueDataView.Columns)
                {
                    iTotalWidth += gridColumn.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                if (bFirstPage)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
