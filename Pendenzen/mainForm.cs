using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Pendenzen.Properties;

namespace Pendenzen
{
    public partial class mainForm : Form
    {

        #region global Variables

        private readonly DBConnect db = new DBConnect();
        private readonly addIssue issue = new addIssue();
        private readonly addCompany company = new addCompany();
        private readonly reorganisation reorg = new reorganisation();
        private readonly password pass = new password();
        private ArrayList _companies;
        private DataTable _table;
        private DataTable oldTable;
        private string query;

        private string printQuery =
            $"SELECT idpendenz, lieferant, referenz, document, sachbearbeiter, due, detail FROM pendenz GROUP BY sachbearbeiter";

        private readonly string baseQuery =
            "SELECT idpendenz, lieferant, referenz, document, sachbearbeiter, due, detail ";

        private StringFormat strFormat;
        private int cellHeight;
        private int iRow;
        private int totalWidth;
        private int headerHeight;
        private bool bFirstPage;
        private bool newPage;
        private bool isOn;
        private readonly ArrayList arrColumnLefts = new ArrayList();
        private readonly ArrayList arrColumnWidths = new ArrayList();

        public void setIsOn(bool on)
        {
            isOn = on;
        }

        public void setQuery(string setQuery)
        {
            query = setQuery;
        }

        #endregion

        public mainForm()
        {
            query = baseQuery + "FROM pendenz WHERE state = 'open'" + admin() + " ORDER BY idpendenz desc";
            InitializeComponent();
            nameLabel.Text =
                $"Name: {person.getInfo()[1]} {person.getInfo()[2]} / {person.getInfo()[0]}\nAbteilung: {person.getInfo()[4]}\nDatum: {DateTime.Today.ToShortDateString()}";

            string[] status = {"open", "done", "cancelled"};
            foreach (var s in status) searchStatusBox.Items.Add(s);
            oldTable = db.Select(query);
            issueDataView.DataSource = oldTable;
            tabControl_Selected(null, null);
            threadStarter();
            isOn = true;
        }

        public Dictionary<string, string> dictionary()
        {
            var dict = new Dictionary<string, string>();

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
            var dict = new Dictionary<string, string>();

            if (tabControl.SelectedIndex == 0)
            {
                dict.Add("idpendenz", "ID");
                dict.Add("lieferant", "Lieferant");
                dict.Add("referenz", "Referenz-Nr.");
                dict.Add("document", "Dokument");
                dict.Add("erfasst_am", "Erstellt am");
                dict.Add("erfasst_von", "Erfasser");
                dict.Add("sachbearbeiter", "Sachbearbeiter");
                dict.Add("due", "Fällig am");
                dict.Add("detail", "Details");
                dict.Add("finalized", "Abgeschlossen am");
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
            var table = db.Select("SELECT company_id FROM company");

            _companies = new ArrayList(table.Rows.Count);
            foreach (DataRow row in table.Rows) _companies.Add(row.ItemArray[0]);

            var currentID = _companies.IndexOf(idLabel.Text) + 1;
            countLabel.Text = $"{currentID} von {_companies.Count}";

            if (currentID == 1) previousButton.Enabled = false;
            else previousButton.Enabled = true;
            if (currentID == _companies.Count) nextButton.Enabled = false;
            else nextButton.Enabled = true;
        }

        #region AutoUpdate

        private void onOffButton_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                isOn = false;
                onOffButton.Text = "off";
                onOffButton.BackColor = Color.Red;
            }
            else if (!isOn)
            {
                isOn = true;
                onOffButton.Text = "on";
                onOffButton.BackColor = Color.Lime;
                reloadData(tabControl.SelectedIndex);
            }
        }

        #endregion

        #region Data

        private void reloadData(int tabIndex)
        {
            if (tabIndex == 0)
            {
                loadIssues();
                formatDataView();
                druckToolStripMenuItem.Enabled = true;

                var maxRows = issueDataView.RowCount;
                if (maxRows == 0)
                {
                    restoreLabel.Visible = true;
                    restoreButton.Visible = true;
                }
                else
                {
                    restoreLabel.Visible = false;
                    restoreButton.Visible = false;
                }
            }
            else if (tabIndex == 1)
            {
                loadContact(idLabel.Text);
                druckToolStripMenuItem.Enabled = false;
            }
        }

        private void loadIssues()
        {
            var rowIndex = issueDataView.FirstDisplayedScrollingRowIndex;
            DataTable newTable = db.Select(query);
           
            if (!AreTablesTheSame(oldTable, newTable))
            {
                issueDataView.DataSource = newTable;
                oldTable = newTable;
            }
            if (rowIndex >= 0)
                issueDataView.FirstDisplayedScrollingRowIndex = rowIndex;
        }

        public static bool AreTablesTheSame(DataTable tbl1, DataTable tbl2)
        {
            if (tbl1.Rows.Count != tbl2.Rows.Count || tbl1.Columns.Count != tbl2.Columns.Count)
                return false;


            for (int i = 0; i < tbl1.Rows.Count; i++)
            {
                for (int c = 0; c < tbl1.Columns.Count; c++)
                {
                    if (!Equals(tbl1.Rows[i][c], tbl2.Rows[i][c]))
                        return false;
                }
            }
            return true;
        }

        private void formatDataView()
        {
            for (var c = 0; c < issueDataView.Columns.Count; c++)
            {
                foreach (var pair in headerDictionary())
                    if (issueDataView.Columns[c].Name == pair.Key)
                        issueDataView.Columns[c].HeaderText = pair.Value;

                if (issueDataView.Columns[c].Name == "detail")
                    issueDataView.Columns[c].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                else
                    issueDataView.Columns[c].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            var contact = new ArrayList(table.Columns.Count);
            foreach (DataRow row in table.Rows)
                foreach (DataColumn column in table.Columns)
                    contact.Add(row[column]);

            kundeLabel.Text = "";
            einkauferLabel.Text = "";

            DateTime kundeDate;
            if (contact[15].ToString() != "")
            {
                kundeDate = DateTime.Parse(contact[15].ToString());
                var date = kundeDate.ToShortDateString();
                kundeLabel.Text = $" Kunde seit: {date}";
            }
            DateTime einkaufDate;
            if (contact[16].ToString() != "")
            {
                einkaufDate = DateTime.Parse(contact[16].ToString());
                var date = einkaufDate.ToShortDateString();
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
            verkaufKontaktLabel.Text = $"Verkauf: {contact[11]}";
            einkaufKontaktLabel.Text = $"Einkauf: {contact[12]}";
            verkaufBusproLabel.Text = $"Verkauf: {contact[13]}";
            einkaufBusproLabel.Text = $"Einkauf: {contact[14]}";
            historyBox.Text = contact[17].ToString();
            getCompanyIndex();
            manageButtons();
        }

        private string createAdressQuery()
        {
            return
                "SELECT company_name, company_street, company_plz, company_city, company_country, company_verkaufmail, company_einkaufmail FROM company WHERE company_verkaufkontakt = 'JA' OR company_einkaufkontakt = 'JA' ";
        }

        private string createQuery(string table)
        {
            printQuery = $"{baseQuery} FROM pendenz {admin()}";
            return $"{baseQuery} FROM {table} {admin().Replace("AND", "WHERE")}";
        }

        private string createQuery(string table, string searchKey)
        {
            if (searchKey == "")
                return createQuery(table);

            printQuery = $"{baseQuery} FROM pendenz WHERE {searchKey} = '' {admin()}";
            return $"{baseQuery} FROM {table} WHERE {searchKey} = '' {admin()}";
        }

        private string createQuery(string table, string searchKey, string searchText)
        {
            if (searchKey == "")
                return createQuery(table);
            printQuery = baseQuery + $"FROM pendenz WHERE {searchKey} LIKE '{searchText}'" + admin();
            return baseQuery + $"FROM {table} WHERE {searchKey} LIKE '{searchText}'" + admin();
        }

        private string admin()
        {
            if (person.getInfo()[4] == "Informatik" || person.getInfo()[4] == "GL")
            {
            return "";
            }
            else
            {
                return $"AND department = '{person.getInfo()[4]}'";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
                issue.ShowDialog();
            if (tabControl.SelectedIndex == 1)
                company.ShowDialog();
        }

        private void issueDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isOn = false;
                var changeIssue = issueDataView.CurrentRow.Cells[0].Value.ToString();

                var modify = new modifyIssue(int.Parse(changeIssue));
                modify.ShowDialog();
            }
        }

        private void issueDataView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isOn = false;
            var sortText = issueDataView.Columns[e.ColumnIndex].HeaderText;
        }

        #endregion

        #region Toolstrip

        private void neuePendenzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issue.ShowDialog();
        }

        private void neueAdresseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            company.ShowDialog();
        }

        private void reorganisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reorg.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pass.ShowDialog();
        }

        private void schliessenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = new info();
            info.ShowDialog();
        }

        private void autoUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isOn = true;
        }

        private void statistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stats = new Stats();
            stats.ShowDialog();
        }

        private void übergabeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ubergabe = new ubergabe();
            ubergabe.ShowDialog();
        }

        #endregion

        #region Address

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            reloadData(tabControl.SelectedIndex);

            searchDropBox.Items.Clear();
            foreach (var pair in dictionary())
                searchDropBox.Items.Add(pair.Key);
            searchDropBox.Text = "";
            searchBox.Text = "";
        }

        private void openLinkButton_Click(object sender, EventArgs e)
        {
            if (urlLabel.Text != "")
                Process.Start(urlLabel.Text);
        }

        private void companyChangeLabel_Click(object sender, EventArgs e)
        {
            var modifyCompany = new modifyCompany(idLabel.Text);

            modifyCompany.ShowDialog();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            var id = _companies.IndexOf(idLabel.Text);
            if (id > 0)
            {
                var previousID = _companies[id - 1].ToString();
                loadContact(previousID);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var id = _companies.IndexOf(idLabel.Text) + 1;
            var nextID = _companies[id].ToString();
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



        private void manageButtons()
        {
            if (urlLabel.Text == "")
            {
                openLinkButton.Visible = false;
                webLabel.Visible = false;
            }
            else
            {
                openLinkButton.Visible = true;
                webLabel.Visible = true;
            }
            if (emailVerkaufLabel.Text == "")
            {
                verkaufEmailButton.Visible = false;
                verkaufLabel.Visible = false;
            }
            else
            {
                verkaufEmailButton.Visible = true;
                verkaufLabel.Visible = true;
            }
            if (emailEinkaufLabel.Text == "")
            {
                einkaufEmailButton.Visible = false;
                einkaufLabel.Visible = false;
            }
            else
            {
                einkaufEmailButton.Visible = true;
                einkaufLabel.Visible = true;
            }
        }

        private void WriteToCSV()
        {
            query = createAdressQuery();

            var table = db.Select(query);

            var result = new StringBuilder();
            for (var i = 0; i < table.Columns.Count; i++)
            {
                result.Append(table.Columns[i].ColumnName);
                result.Append(i == table.Columns.Count - 1 ? "\n" : ",");
            }

            foreach (DataRow row in table.Rows)
                for (var i = 0; i < table.Columns.Count; i++)
                {
                    result.Append(row[i]);
                    result.Append(i == table.Columns.Count - 1 ? "\n" : ",");
                }

            var saveFile = new SaveFileDialog();

            saveFile.FileName = "export.csv";
            saveFile.DefaultExt = "csv";
            saveFile.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE");
            saveFile.Title = "Adressen exportieren unter";
            saveFile.Filter = "Alle Dateien (*.*)|*.*";
            saveFile.CheckPathExists = true;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                var path = saveFile.FileName;
                File.WriteAllText(path, result.ToString(), Encoding.Unicode);
            }
        }

        #endregion

        #region Search

        private void reset_Click(object sender, EventArgs e)
        {
            query = baseQuery + "FROM pendenz WHERE state = 'open' " + admin() +" ORDER BY idpendenz desc";
            isOn = true;
            searchBox.Clear();
            searchDropBox.Text = "";
            searchStatusBox.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            dictionary();

            var searchKey = "";

            dictionary().TryGetValue(searchDropBox.Text, out searchKey);

            if (searchDropBox.Text != "")
            {
                if (tabControl.SelectedIndex == 0)
                {
                    if (searchStatusBox.Visible)
                        query = createQuery("pendenz", searchKey, searchStatusBox.Text);
                    else if (searchBox.Visible && (searchBox.Text != ""))
                        query = createQuery("pendenz", searchKey, searchBox.Text);
                    else if (searchBox.Visible && (searchBox.Text == ""))
                        query = createQuery("pendenz", searchKey);
                    issueDataView.DataSource = db.Select(query);
                }
                if (tabControl.SelectedIndex == 1)
                    loadContact(searchKey, searchBox.Text);
            }
            else
            {
                var result = MessageBox.Show(Resources.Suchkriterien, "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            isOn = true;
        }

        private void searchDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchDropBox.Text == "Status")
            {
                searchBox.Visible = false;
                searchBox.Clear();
                searchStatusBox.Visible = true;
            }
            else
            {
                searchBox.Visible = true;
                searchStatusBox.Visible = false;
                searchStatusBox.Text = "";
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            restoreButton.Visible = false;
            restoreLabel.Visible = false;
            reset_Click(sender, e);
        }

        private void searchBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                searchButton_Click(searchButton, e);
        }

        #endregion

        #region MultiThreading

        private void threadStarter()
        {
            var thread = new Thread(threadTask);
            thread.IsBackground = true;
            thread.Start();
        }

        private void threadTask()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (isOn)
                {
                    Invoke((MethodInvoker) delegate { reloadData(tabControl.SelectedIndex); });
                    Invoke((MethodInvoker) delegate { onOffButton.BackColor = Color.Lime; });
                    Invoke((MethodInvoker) delegate { infoLabel.Visible = false; });
                }
                if (!isOn)
                {
                    Invoke((MethodInvoker) delegate { onOffButton.BackColor = Color.Red; });
                    Invoke((MethodInvoker) delegate { infoLabel.Text = Resources.autoUpdateOff; });
                    Invoke((MethodInvoker) delegate { infoLabel.Visible = true; });
                }
            }
        }

        #endregion

        #region Printing

        private void queryPrint()
        {
            isOn = false;
            issueDataView.DataSource = db.Select(printQuery);
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            queryPrint();

            var printPreview = new PrintPreviewDialog();
            printPreview.Icon = Resources.favicon;
            printPreview.Document = printIssues;
            printIssues.DefaultPageSettings.Landscape = true;
            ((Form) printPreview).WindowState = FormWindowState.Maximized;

            printPreview.ShowDialog();
        }

        private void druckenButton_Click(object sender, EventArgs e)
        {
            queryPrint();

            // Open print dialog
            var printDialog = new PrintDialog();
            printDialog.Document = printIssues;
            printDialog.UseEXDialog = true;

            // Get document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printIssues.DocumentName = "Pendenzen";
                printIssues.DefaultPageSettings.Landscape = true;
                printIssues.Print();
            }
        }

        private void printIssues_BeginPrint(object sender, PrintEventArgs e)
        {
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
                    totalWidth += gridColumn.Width;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printIssues_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                var leftMargin = e.MarginBounds.Left;
                var topMargin = e.MarginBounds.Top;
                var morePagesToPrint = false;
                var tmpWidth = 0;

                if (bFirstPage)
                    foreach (DataGridViewColumn gridColumn in issueDataView.Columns)
                    {
                        tmpWidth = (int) Math.Floor(gridColumn.Width/
                                                    (double) totalWidth*totalWidth*
                                                    (e.MarginBounds.Width/(double) totalWidth));

                        headerHeight = (int) e.Graphics.MeasureString(gridColumn.HeaderText,
                                           gridColumn.InheritedStyle.Font, tmpWidth).Height + 20;

                        arrColumnLefts.Add(leftMargin);
                        arrColumnWidths.Add(tmpWidth);
                        leftMargin += tmpWidth;
                    }
                while (iRow <= issueDataView.Rows.Count - 1)
                {
                    var gridRow = issueDataView.Rows[iRow];
                    cellHeight = gridRow.Height + 20;
                    var iCount = 0;

                    if (topMargin + cellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        newPage = true;
                        bFirstPage = false;
                        morePagesToPrint = true;
                        break;
                    }
                    if (newPage)
                    {
                        // Draw Header
                        var topString = "Pendenzenübersicht";
                        e.Graphics.DrawString(topString,
                            new Font(issueDataView.Font, FontStyle.Bold),
                            Brushes.Black,
                            e.MarginBounds.Left,
                            e.MarginBounds.Top -
                            e.Graphics.MeasureString(topString, new Font(issueDataView.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height);

                        var date = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                        // Draw Date
                        e.Graphics.DrawString(date,
                            new Font(issueDataView.Font, FontStyle.Bold),
                            Brushes.Black,
                            e.MarginBounds.Left +
                            (e.MarginBounds.Width - e.Graphics.MeasureString(date, new Font(issueDataView.Font,
                                 FontStyle.Bold), e.MarginBounds.Width).Width),
                            e.MarginBounds.Top - e.Graphics.MeasureString(topString,
                                new Font(new Font(issueDataView.Font, FontStyle.Bold),
                                    FontStyle.Bold), e.MarginBounds.Width).Height);

                        // Draw Columns
                        topMargin = e.MarginBounds.Top;

                        foreach (DataGridViewColumn gridColumn in issueDataView.Columns)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int) arrColumnLefts[iCount], topMargin,
                                    (int) arrColumnWidths[iCount], headerHeight));

                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int) arrColumnLefts[iCount], topMargin,
                                    (int) arrColumnWidths[iCount], headerHeight));

                            e.Graphics.DrawString(gridColumn.HeaderText,
                                gridColumn.InheritedStyle.Font,
                                new SolidBrush(gridColumn.InheritedStyle.ForeColor),
                                new RectangleF((int) arrColumnLefts[iCount], topMargin,
                                    (int) arrColumnWidths[iCount], headerHeight), strFormat);
                            iCount++;
                        }
                        newPage = false;
                        topMargin += headerHeight;
                    }
                    iCount = 0;

                    // Draw Columns Content
                    foreach (DataGridViewCell cell in gridRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            var rectF = new RectangleF((int) arrColumnLefts[iCount],
                                topMargin, (int) arrColumnWidths[iCount], cellHeight);

                            e.Graphics.DrawString(cell.Value.ToString(),
                                cell.InheritedStyle.Font,
                                new SolidBrush(cell.InheritedStyle.ForeColor),
                                rectF, strFormat);
                        }
                        // Draw Cells Borders
                        var rect = new Rectangle((int) arrColumnLefts[iCount],
                            topMargin, (int) arrColumnWidths[iCount], cellHeight);
                        e.Graphics.DrawRectangle(Pens.Black, rect);
                        iCount++;
                    }
                    iRow++;
                    topMargin += cellHeight;
                }
                // If more lines exist, print another page
                if (morePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printIssues_EndPrint(object sender, PrintEventArgs e)
        {
            //isOn = true;
        }

        #endregion
    }
}