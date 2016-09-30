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
    public partial class modifyIssue : Form
    {
        int _id;
        string _company;
        string _reference;
        string _document;
        string _responsible;
        DateTime _due;
        string changesText;

        public modifyIssue(int id)
        {
            InitializeComponent();
            _id = id;
            DBConnect db = new DBConnect();
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

            changeIssueLabel.Text = $"Pendenz #{id} bearbeiten";
            creatorLabel.Text = $"Erfasser: {list[5]}";
            dateLabel.Text = $"Erfasst am: {list[4]}";
            companyBox.Text = _company;
            referenceTextBox.Text = _reference;
            documentTextBox.Text = _document;
            responsibleTextBox.Text = _responsible;
            duePicker.Value = _due;
            historyTextBox.Text = list[8];
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("dd. MMM. yy HH:mm"));

            string newState;
            string finalizedDate;

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

            

            string detailsText = $"{DateTime.Now.ToString("dd. MMM. yy HH:mm")} {person.getUserFullName()}\n{detailsTextBox.Text}\n{changesText}" + historyTextBox.Text;





            if (finalizedButton.Checked)
            {
                newState = "done";
                finalizedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            } else if (cancelButton.Checked)
            {
                newState = "cancelled";
                finalizedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            } else
            {
                newState = "open";
                finalizedDate = "";
            }

            string lieferant = $"lieferant = '{companyBox.Text}'";
            string referenz = $"referenz = '{referenceTextBox.Text}'";
            string document = $"document = '{documentTextBox.Text}'";
            string sachbearbeiter = $"sachbearbeiter = '{responsibleTextBox.Text}'";
            string due = $"due = '{duePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")}'";
            string detail = $"detail = '{detailsText}'";
            string finalized = $"finalized = '{finalizedDate}'";
            string state = $"state = '{newState}'";

            DBConnect db = new DBConnect();
            string query;
            if (newState == "open")
            {
                query = $"UPDATE pendenz SET {lieferant}, {referenz}, {document}, {sachbearbeiter}, {due}, {detail} WHERE idpendenz={_id}";
            }
            else
            {
                query = $"UPDATE pendenz SET {lieferant}, {referenz}, {document}, {sachbearbeiter}, {due}, {detail}, {finalized}, {state}  WHERE idpendenz={_id}";
            }
            
            Console.WriteLine(query);
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

        private void companyBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = "Wählen Sie die, die Pendenz betreffende Firma.";
        }

        private void referenceTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = "Die Referenznummer entspricht unserer Bestellnummer im BusPro.";
        }

        private void documentTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = "Die Belegnummer entspricht der Dokumentennummer der Lieferfirma. Auftragsbestätigung (AB), Lieferschein (LS), Gutschrift (GU) oder Rechnung (RG).";
        }

        private void responsibleTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = "Der zuständige Sachbearbeiter (SB) entspricht demjenigen, der die Pendenz bearbeitet.";
        }

        private void duePicker_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = "An diesem Tag ist die Pendenz zu beenden.";
        }

        private void detailsTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = "Jeder unternommene Schritt ist mit einem kurzen Satz zu dokumentieren.";
        }
    }
}
