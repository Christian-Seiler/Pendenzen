using System;
using System.Data;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class addIssue : Form
    {
        DBConnect db = new DBConnect();
        bool _error = false;

        public addIssue()
        {
            InitializeComponent();
            
            creatorLabel.Text = "Erfasser: " + person.getUserFullName();
            dateLabel.Text = $"Datum: {DateTime.Today.ToShortDateString()}";
            duePicker.Value = DateTime.Now.AddDays(7);
        }

        private void setCompanyBox()
        {
            string query = "SELECT company_id FROM company";
            DataTable dataTable = db.Select(query);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    companyBox.Items.Add(row[column]);
                }
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            addCompany add = new addCompany();
            add.ShowDialog();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string detailsText = $"{DateTime.Now.ToString()} {person.getUserFullName()}\n{detailsTextBox.Text}";

            string lieferant = companyBox.Text;
            string referenz = referenceTextBox.Text;
            string document = documentTextBox.Text;
            string erfasstAm = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string erfasstVon = person.getUserName().ToUpper();
            string sachbearbeiter = responsibleTextBox.Text.ToUpper();
            string due = duePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string details = detailsText;
            
            checkEntries();
            if (_error == false)
            {
                string query = $"INSERT INTO pendenz (lieferant, referenz, document, erfasst_am, erfasst_von, sachbearbeiter, due, detail) VALUES('{lieferant}', '{referenz}', '{document}', '{erfasstAm}', '{erfasstVon}', '{sachbearbeiter}', '{due}', '{details}')";
                db.Insert(query);
                Close();
            }
        }

        private void checkEntries()
        {
            errorLabel.Text = "";

            if(companyBox.Text == "")
            {
                _error = true;
                errorLabel.Text += "Firmenangabe";
            }
            if(referenceTextBox.Text == "" && documentTextBox.Text == "")
            {
                if(_error == true) { errorLabel.Text += ", "; }
                _error = true;
                errorLabel.Text += "Referenz oder Beleg";
            }
            if (responsibleTextBox.Text == "")
            {
                if (_error == true) { errorLabel.Text += ", "; }
                _error = true;
                errorLabel.Text += "Sachbearbeiter";
            }
            if (detailsTextBox.Text == "")
            {
                if (_error == true) { errorLabel.Text += ", "; }
                _error = true;
                errorLabel.Text += "Detailangabe";
            }
            if (_error)
            {
                errorLabel.Text += " ist zwingend einzugeben.";
            }
            errorLabel.Visible = true;
        }

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