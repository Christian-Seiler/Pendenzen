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
    public partial class addCompany : Form
    {
        DBConnect db = new DBConnect();
        string Date = DateTime.Now.ToShortDateString();
        string neukundeVerkauf = "null";
        string neukundeEinkauf = "null";

        public addCompany()
        {
            InitializeComponent();
        }

        public addCompany(string id)
        {
            InitializeComponent();
            companyIDTextBox.Text = id;
        }

        private void getCountry(object sender, EventArgs e)
        {
            string companyID;
            int textLength;
            if (companyIDTextBox.TextLength >= 3)
            {
                if (companyIDTextBox.TextLength == 3)
                {
                    companyID = $"CH-{companyIDTextBox.Text}";
                    textLength = 6;
                }
                else
                {
                    textLength = companyIDTextBox.TextLength;
                    companyID = companyIDTextBox.Text;
                }
                string query = $"SELECT countryname FROM country WHERE idcountry='{companyID.Remove(textLength - 4)}'";



                List<string> list = new List<string>();
                var i = 0;
                DataTable data = db.Select(query);
                foreach (DataRow row in data.Rows)
                {
                    foreach (DataColumn col in data.Columns)
                    {
                        list.Add(row.ItemArray[i].ToString());
                        i++;
                    }
                }

                countryTextBox.Text = list[0];
            }
        }

        private void neukundeVerkauf_Checked(object sender, EventArgs e)
        {
            neukundeVerkauf = $"{Date}";
        }

        private void neukundeEinkauf_Checked(object sender, EventArgs e)
        {
            neukundeEinkauf = $"{Date}";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (companyIDTextBox.TextLength > 0)
            {
                string newDetails = $"Firma {companyIDTextBox.Text} erstellt\n{companyTextBox.Text}, {streetTextBox.Text}, {plzTextBox.Text}, {cityTextBox.Text}";
                string history = $"{DateTime.Now.ToString("dd. MMM. yy HH:mm")} {person.getUserFullName()}\n{newDetails}";

                string verkaufKontakt = "Nein";
                string einkaufKontakt = "Nein";
                string verkaufBuspro = "Nein";
                string einkaufBuspro = "Nein";

                if (verkaufKontaktCheck.Checked)
                {
                    verkaufKontakt = "Ja";
                }
                if (einkaufKontaktCheck.Checked)
                {
                    einkaufKontakt = "Ja";
                }
                if (verkaufBusproCheck.Checked)
                {
                    verkaufBuspro = "Ja";
                }
                if (einkaufBusproCheck.Checked)
                {
                    einkaufBuspro = "Ja";
                }


                string query = $"INSERT INTO company VALUES ('{companyIDTextBox.Text}', '{companyTextBox.Text}', '{streetTextBox.Text}', '{poBoxTextBox.Text}', '{plzTextBox.Text}', '{cityTextBox.Text}', '{countryTextBox.Text}', '{phoneTextBox.Text}', '{urlTextBox.Text}', '{emailVerkaufTextBox.Text}', '{emailEinkaufTextBox.Text}', '{verkaufKontakt}', '{einkaufKontakt}', '{verkaufBuspro}', '{einkaufBuspro}', {neukundeVerkauf}, {neukundeEinkauf}, '{history}')";
                Console.WriteLine(query);
                db.Insert(query);
                Close();
            }
            else
            {
                DialogResult result = MessageBox.Show(Properties.Resources.idRequired, 
                    "Fehlende Eingabe", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question);
            }
        }

        private void copyMailCheck_CheckStateChanged(object sender, EventArgs e)
        {
            emailEinkaufTextBox.Text = emailVerkaufTextBox.Text;
        }
    }
}
