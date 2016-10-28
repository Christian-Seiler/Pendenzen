using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class modifyIssue : Form
    {
        int _id;
        string _company;
        string _reference;
        string _document;
        string _responsible;
        string _state;
        DateTime _due;
        DBConnect db = new DBConnect();

        
        string changesText;

        public modifyIssue(int id)
        {
            InitializeComponent();
            _id = id;
            string query = $"SELECT * FROM pendenz WHERE idpendenz = {id}";
            DataTable dataTable = db.Select(query);


            List<string> list = new List<string>();
            var i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    list.Add(row.ItemArray[i].ToString());
                    i++;
                }
            }
            
            query = "SELECT company_id FROM company";
            dataTable = db.Select(query);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    companyBox.Items.Add(row[column]);
                }
            }

            _company = list[1];
            _reference = list[2];
            _document = list[3];
            _responsible = list[6];
            _due = Convert.ToDateTime(list[7]);
            _state = list[10];

            changeIssueLabel.Text = $"Pendenz #{id} bearbeiten";
            creatorLabel.Text = $"Erfasser: {list[5]}";
            dateLabel.Text = $"Erfasst am: {list[4]}";
            companyBox.Text = _company;
            referenceTextBox.Text = _reference;
            documentTextBox.Text = _document;
            responsibleTextBox.Text = _responsible;
            duePicker.Value = _due;
            historyTextBox.Text = list[8];

            switch (_state)
            {
                case "cancelled":
                    cancelButton.Checked = true;
                    break;
                case "done":
                    finalizedButton.Checked = true;
                    break;
                default:
                    openButton.Checked = true;
                    break;
            }
        }

        #region UI
        private void okButton_Click(object sender, EventArgs e)
        {
            string newState = "";
            string finalizedDate = "";

            List<string> changes = new List<string>();
            
            if (companyBox.Text != _company)
            {
                changes.Add("Firma: " + companyBox.Text);
            }
            if (referenceTextBox.Text != _reference)
            {
                changes.Add("Referenz: " + referenceTextBox.Text);
            }
            if (documentLabel.Text != _document)
            {
                changes.Add("Beleg: " + documentTextBox.Text);
            }
            if (responsibleTextBox.Text != _responsible)
            {
                changes.Add("SB: " + responsibleTextBox.Text);
            }
            if (duePicker.Value != _due)
            {
                changes.Add("Fällig: " + duePicker.Value.ToShortDateString());
            }
            if (changes.Count != 0)
            {
                changesText = string.Join(", ", changes.ToArray());
                changesText = "Änderungen: " + changesText + "\n";
            }

            string newDetails = "";
            if (detailsTextBox.Text != "")
            {
                newDetails = detailsTextBox.Text + "\n";
            }

            string detailsText = $"{DateTime.Now.ToString("dd. MMM. yy HH:mm")} {person.getUserFullName()}\n{newDetails}{changesText}" + historyTextBox.Text;

            if (finalizedButton.Checked)
            {
                newState = "done";
                finalizedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            } else if (cancelButton.Checked)
            {
                newState = "cancelled";
                finalizedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            } else if (openButton.Checked)
            {
                newState = "open";
                finalizedDate = "";
            }

            string lieferant = $"lieferant = `{companyBox.Text}`";
            string referenz = $"referenz = `{referenceTextBox.Text}`";
            string document = $"document = `{documentTextBox.Text}`";
            string sachbearbeiter = $"sachbearbeiter = `{responsibleTextBox.Text}`";
            string due = $"due = `{duePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}`";
            string detail = $"detail = `{detailsText}`";
            string finalized;
            if (finalizedDate == "")
            {
                finalized = "finalized = null";
            }
            else
            {
                finalized = $"finalized = `{finalizedDate}`";
            }
            string state = $"state = `{newState}`";

            string  query = $"UPDATE pendenz SET {lieferant}, {referenz}, {document}, {sachbearbeiter}, {due}, {detail}, {finalized}, {state}  WHERE idpendenz={_id}";

            db.Update(query);
            Close();
        }

        private void stateButton(object sender, EventArgs e)
        {
            if (finalizedButton.Checked)
            {
                cancelButton.Checked = false;
                openButton.Checked = false;
            }
            if (cancelButton.Checked)
            {
                finalizedButton.Checked = false;
                openButton.Checked = false;
            }
            if (openButton.Checked)
            {
                finalizedButton.Checked = false;
                cancelButton.Checked = false;
            }
        }

        private void openFilesButton_Click(object sender, EventArgs e)
        {
            if (_company.Length == 3)
            {
                string path = @"K:\Einkauf\Lieferanten\Inland\" + _company + @"\Korrespondenz";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                Process.Start(path);
            }
            else
            {
                string path = @"K:\Einkauf\Lieferanten\Ausland\" + _company + @"\Korrespondenz";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                Process.Start(path);
            }
        }

        private void detailsFirmaButton_Click(object sender, EventArgs e)
        {
             var isInDatabase = db.Count($"SELECT COUNT(*) FROM company WHERE company_id = '{_company}'");

            if (isInDatabase > 0)
            {
                Firmendetails company = new Firmendetails(companyBox.Text);
                company.ShowDialog();
            }
            else
            {
                addCompany add = new addCompany(_company);
                add.ShowDialog();
            }
        }

        #endregion

        #region Helptext

        private void companyBox_Focused(object sender, EventArgs e)
        {

            helpTextBox.Text = Properties.Resources.helpCompany;
        }

        private void referenceTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Properties.Resources.helpReference;
        }

        private void documentTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Properties.Resources.helpDocument;
        }

        private void responsibleTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Properties.Resources.helpSB;
        }

        private void duePicker_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Properties.Resources.helpDue;
        }

        private void detailsTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Properties.Resources.helpDetails;
        }
        #endregion
    }
}
