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
        int cellHeight = 0;
        int iRow = 0;
        int totalWidth = 0;
        int headerHeight = 0;
        bool bFirstPage = false;
        bool newPage = false;
        bool isPrinting = false;
        bool isSorted = false;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();


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
        public Dictionary<string, string> headerDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            if (tabControl.SelectedIndex == 0)
            {
                dict.Add("idpendenz", "ID");
                dict.Add("lieferant", "Lieferant");
                dict.Add("referenz", "Referenz-Nr.");
                dict.Add("dokument", "Dokument");
                dict.Add("erfasst_am", "Erstellt am");
                dict.Add("erfasst_von", "Erfasser");
                dict.Add("sachbearbeiter", "Sachbearbeiter");
                dict.Add("due", "Fällig am");
                dict.Add("detail", "Details");
                dict.Add("finalized", "Abgeschlossen");
                dict.Add("state", "Status");
            }
            if (tabControl.SelectedIndex == 1)
            {
                dict.Add("company_id", "Kürzel");
                dict.Add("company_name", "Lieferant");
                dict.Add("company_plz", "PLZ");
                dict.Add("company_city", "City");
                dict.Add("company_country", "Land");
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
            query = "SELECT * FROM pendenz WHERE state = 'open' ORDER BY idpendenz desc";
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
            int rowIndex = issueDataView.FirstDisplayedScrollingRowIndex;
            issueDataView.DataSource = db.Select(query);
            if (rowIndex >= 0)
            {
                issueDataView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
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
            isSorted = false;
            reloadData(tabControl.SelectedIndex);
        }

        private void issueDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string changeIssue = issueDataView.CurrentRow.Cells[0].Value.ToString();

                modifyIssue modify = new modifyIssue(int.Parse(changeIssue));
                modify.ShowDialog();
            }
        }
        private void issueDataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sortText = issueDataView.Columns[e.ColumnIndex].HeaderText;
            isSorted = true;
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
                if (isPrinting)
                {
                    queryPrint();
                }
                else if (!isPrinting && !isSorted)
                {
                    this.Invoke((MethodInvoker)delegate { reloadData(tabControl.SelectedIndex); });
                }

                Console.WriteLine($"is Printing {isPrinting} / is Sorted {isSorted}");
                Thread.Sleep(5000);
            }
        }
        #endregion

        #region Printing
        private void queryPrint()
        {
            isPrinting = true;
            Console.WriteLine("query Print");
            Console.WriteLine($"is Printing {isPrinting} / is Sorted {isSorted}");
            string printQuery = "SELECT idpendenz, lieferant, referenz, document, sachbearbeiter, due, detail FROM pendenz GROUP BY sachbearbeiter;";
            issueDataView.DataSource = db.Select(printQuery);
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            isPrinting = true;
            queryPrint();

            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printIssues;
            printIssues.DefaultPageSettings.Landscape = true;
            ((Form)printPreview).WindowState = FormWindowState.Maximized;
            
            printPreview.ShowDialog();
            Console.WriteLine("previewButton_Click");
        }

        private void druckenButton_Click(object sender, EventArgs e)
        {
            isPrinting = true;
            queryPrint();

            // Open print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printIssues;
            printDialog.UseEXDialog = true;

            // Get document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printIssues.DocumentName = "Pendenzen";
                printIssues.DefaultPageSettings.Landscape = true;
                printIssues.Print();
            }
            Console.WriteLine("druckenButton_Click");
        }

        private void printIssues_BeginPrint(object sender, PrintEventArgs e)
        {
            isPrinting = true;
            queryPrint();
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                cellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                newPage = true;

                // Calculating Total Widths
                totalWidth = 0;
                foreach (DataGridViewColumn gridColumn in issueDataView.Columns)
                {
                    totalWidth += gridColumn.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isPrinting = false;
            }
            Console.WriteLine("printIssues_BeginPrint");
        }

        private void printIssues_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Console.WriteLine("Printpage Try");
                int leftMargin = e.MarginBounds.Left;
                int topMargin = e.MarginBounds.Top;
                bool morePagesToPrint = false;
                int tmpWidth = 0;

                if (bFirstPage)
                {
                    Console.WriteLine("firstPage");
                    foreach (DataGridViewColumn gridColumn in issueDataView.Columns)
                    {
                        tmpWidth = (int)(Math.Floor((double)((double)gridColumn.Width /
                            (double)totalWidth * (double)totalWidth * ((double)e.MarginBounds.Width / (double)totalWidth))));

                        headerHeight = (int)(e.Graphics.MeasureString(gridColumn.HeaderText, 
                            gridColumn.InheritedStyle.Font, tmpWidth).Height) + 20;

                        arrColumnLefts.Add(leftMargin);
                        arrColumnWidths.Add(tmpWidth);
                        leftMargin += tmpWidth;
                    }
                }
                while (iRow <= issueDataView.Rows.Count - 1)
                {
                    DataGridViewRow gridRow = issueDataView.Rows[iRow];
                    cellHeight = gridRow.Height + 20;
                    int iCount = 0;

                    if (topMargin + cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        newPage = true;
                        bFirstPage = false;
                        morePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (newPage)
                        {
                            Console.WriteLine("newPage");
                            // Draw Header
                            string topString = "Pendenzenübersicht";
                            e.Graphics.DrawString(topString,
                                new Font(issueDataView.Font, FontStyle.Bold), 
                                Brushes.Black,
                                e.MarginBounds.Left, 
                                e.MarginBounds.Top - e.Graphics.MeasureString(topString, new Font(issueDataView.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height);

                            string date = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            // Draw Date
                            e.Graphics.DrawString(date, 
                                new Font(issueDataView.Font, FontStyle.Bold), 
                                Brushes.Black, 
                                e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(date, new Font(issueDataView.Font, 
                                FontStyle.Bold), e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString(topString, 
                                new Font(new Font(issueDataView.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height);

                            // Draw Columns
                            topMargin = e.MarginBounds.Top;
                            
                            foreach (DataGridViewColumn gridColumn in issueDataView.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], topMargin,
                                    (int)arrColumnWidths[iCount], headerHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], topMargin,
                                    (int)arrColumnWidths[iCount], headerHeight));

                                e.Graphics.DrawString(gridColumn.HeaderText,
                                    gridColumn.InheritedStyle.Font,
                                    new SolidBrush(gridColumn.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], topMargin,
                                    (int)arrColumnWidths[iCount], headerHeight), strFormat);
                                iCount++;
                            }
                            newPage= false;
                            topMargin += headerHeight;
                        }
                        iCount = 0;

                        // Draw Columns Content
                        foreach (DataGridViewCell cell in gridRow.Cells)
                        {
                            if (cell.Value != null)
                            {
                                RectangleF rectF = new RectangleF((int)arrColumnLefts[iCount], 
                                    (float)topMargin, (int)arrColumnWidths[iCount], (float)cellHeight);

                                e.Graphics.DrawString(cell.Value.ToString(),
                                   cell.InheritedStyle.Font,
                                   new SolidBrush(cell.InheritedStyle.ForeColor),
                                   rectF, strFormat);
                            }
                            // Draw Cells Borders
                            Rectangle rect = new Rectangle((int)arrColumnLefts[iCount], 
                                topMargin, (int)arrColumnWidths[iCount], cellHeight);
                            e.Graphics.DrawRectangle(Pens.Black, rect);
                            iCount++;
                        }
                    }
                    iRow++;
                    topMargin += cellHeight;
                }
                // If more lines exist, print another page
                if (morePagesToPrint)
                {
                    e.HasMorePages = true;
                }
                else
                {
                    e.HasMorePages = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isPrinting = false;
            }
            Console.WriteLine("printIssues_PrintPage");
        }
        #endregion
    }
}