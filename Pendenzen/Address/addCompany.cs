using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Pendenzen.Properties;

namespace Pendenzen
{
    public partial class addCompany : Form
    {
        private readonly string Date = DateTime.Now.ToShortDateString();
        private readonly DBConnect db = new DBConnect();
        private string neukundeEinkauf = "null";
        private string neukundeVerkauf = "null";

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


                var list = new List<string>();
                var i = 0;
                var data = db.Select(query);
                foreach (DataRow row in data.Rows)
                    foreach (DataColumn col in data.Columns)
                    {
                        list.Add(row.ItemArray[i].ToString());
                        i++;
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
                string newDetails =
                    $"Firma {companyIDTextBox.Text} erstellt\n{companyTextBox.Text}, {streetTextBox.Text}, {plzTextBox.Text}, {cityTextBox.Text}";
                string history =
                    $"{DateTime.Now.ToString("dd. MMM. yy HH:mm")} {person.getInfo()}[1] {person.getInfo()}[2]\n{newDetails}";

                var verkaufKontakt = "Nein";
                var einkaufKontakt = "Nein";
                var verkaufBuspro = "Nein";
                var einkaufBuspro = "Nein";

                if (verkaufKontaktCheck.Checked)
                    verkaufKontakt = "Ja";
                if (einkaufKontaktCheck.Checked)
                    einkaufKontakt = "Ja";
                if (verkaufBusproCheck.Checked)
                    verkaufBuspro = "Ja";
                if (einkaufBusproCheck.Checked)
                    einkaufBuspro = "Ja";

                string query =
                    $"INSERT INTO company VALUES ('{companyIDTextBox.Text}', '{companyTextBox.Text.Replace("'", "''")}', '{streetTextBox.Text.Replace("'", "''")}', '{poBoxTextBox.Text}', '{plzTextBox.Text}', '{cityTextBox.Text.Replace("'", "''")}', '{countryTextBox.Text}', '{phoneTextBox.Text}', '{urlTextBox.Text}', '{emailVerkaufTextBox.Text}', '{emailEinkaufTextBox.Text}', '{verkaufKontakt}', '{einkaufKontakt}', '{verkaufBuspro}', '{einkaufBuspro}', {neukundeVerkauf}, {neukundeEinkauf}, '{history.Replace("'", "''")}')";
                Console.WriteLine(query);
                db.Insert(query);
                Close();
            }
            else
            {
                var result = MessageBox.Show(Resources.idRequired,
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