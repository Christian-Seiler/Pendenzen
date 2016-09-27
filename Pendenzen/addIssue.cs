using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Types;

namespace Pendenzen
{
    public partial class addIssue : Form
    {
        public addIssue()
        {
            InitializeComponent();
            
            creatorLabel.Text = "Erfasser: " + person.getUserFullName();
            dateLabel.Text = $"Datum: {DateTime.Today.ToShortDateString()}";

            DBConnect db = new DBConnect();
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
            if (responsibleTextBox.Text.Length > 5)
            {
                responsibleTextBox.Text = "";
            } else
            {
                //string lieferant = companyBox.SelectedText.ToString();
                string lieferant = companyBox.Text;
                string referenz = referenceTextBox.Text;
                string document = documentTextBox.Text;
                string erfasstAm = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string erfasstVon = person.getUserName().ToUpper();
                string sachbearbeiter = responsibleTextBox.Text.ToUpper();
                string due = duePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string details = detailsTextBox.Text;

                DBConnect db = new DBConnect();
                string query = $"INSERT INTO pendenz (lieferant, referenz, document, erfasst_am, erfasst_von, sachbearbeiter, due, detail) VALUES('{lieferant}', '{referenz}', '{document}', '{erfasstAm}', '{erfasstVon}', '{sachbearbeiter}', '{due}', '{details}')";
                db.Insert(query);
                issueForm reload = new issueForm();
                reload.reloadData();
                Close();
            }
        }
    }
}
