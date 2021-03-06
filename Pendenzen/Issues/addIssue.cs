﻿using System;
using System.Data;
using System.Windows.Forms;
using Pendenzen.Properties;

namespace Pendenzen
{
    public partial class AddIssue : Form
    {
        private bool _error;
        private readonly DBConnect db = new DBConnect();

        public AddIssue()
        {
            InitializeComponent();
            if (Person.isAdmin())
            {
                departmentLabel.Visible = true;
                departmentBox.Visible = true;
                foreach (String d in Departments.getList())
                {
                    departmentBox.Items.Add(d);
                }
            }

            setCompanyBox();

            creatorLabel.Text = $"Erfasser: {Person.getInfo()[1]} {Person.getInfo()[2]}";
            abteilungLabel.Text = $"Abteilung: {Person.getInfo()[4]}";
            dateLabel.Text = $"Datum: {DateTime.Today.ToShortDateString()}";
            duePicker.Value = DateTime.Now.AddDays(7);
        }

        private void setCompanyBox()
        {
            var query = "SELECT company_id FROM company";
            var dataTable = db.Select(query);

            foreach (DataRow row in dataTable.Rows)
                foreach (DataColumn column in dataTable.Columns)
                    companyBox.Items.Add(row[column]);
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            var add = new addCompany();
            add.ShowDialog();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string detailsText = $"{DateTime.Now} {Person.getInfo()[1]} {Person.getInfo()[2]}\n{detailsTextBox.Text}";

            var lieferant = companyBox.Text;
            var referenz = referenceTextBox.Text;
            var document = documentTextBox.Text;
            var erfasstAm = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string erfasstVon = Person.getInfo()[0];
            var sachbearbeiter = responsibleTextBox.Text.ToUpper();
            var due = duePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
            var details = detailsText;
            string department = "";
            if (Person.isAdmin() && departmentBox.Text != "")
            {
                department = departmentBox.Text;
            } else
            {
                department = Person.getInfo()[4];
            }

            checkEntries();
            if (_error == false)
            {
                string query =
                    $"INSERT INTO pendenz (lieferant, referenz, document, erfasst_am, erfasst_von, sachbearbeiter, due, detail, department) VALUES" +
                    $"('{lieferant}', '{referenz.Replace("'", "''")}', '{document.Replace("'", "''")}', '{erfasstAm}', '{erfasstVon}', '{sachbearbeiter}', '{due}', '{details.Replace("'", "''")}', '{department}')";
  
                db.Insert(query);
                Close();
            }
        }

        private void checkEntries()
        {
            errorLabel.Text = "";

            if (companyBox.Text == "")
            {
                _error = true;
                errorLabel.Text += "Firmenangabe";
            }
            if ((referenceTextBox.Text == "") && (documentTextBox.Text == ""))
            {
                if (_error) errorLabel.Text += ", ";
                _error = true;
                errorLabel.Text += "Referenz oder Beleg";
            }
            if (responsibleTextBox.Text == "")
            {
                if (_error) errorLabel.Text += ", ";
                _error = true;
                errorLabel.Text += "Sachbearbeiter";
            }
            if (detailsTextBox.Text == "")
            {
                if (_error) errorLabel.Text += ", ";
                _error = true;
                errorLabel.Text += "Detailangabe";
            }
            if (_error)
                errorLabel.Text += " ist zwingend einzugeben.";
            errorLabel.Visible = true;
        }

        #region Helptext

        private void companyBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Resources.helpCompany;
        }

        private void referenceTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Resources.helpReference;
        }

        private void documentTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Resources.helpDocument;
        }

        private void responsibleTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Resources.helpSB;
        }

        private void duePicker_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Resources.helpDue;
        }

        private void detailsTextBox_Focused(object sender, EventArgs e)
        {
            helpTextBox.Text = Resources.helpDetails;
        }

        #endregion
    }
}