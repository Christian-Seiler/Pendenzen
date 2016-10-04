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
        string neukundeVerkauf = "0000-00-00";
        string neukundeEinkauf = "0000-00-00";

        public addCompany()
        {
            InitializeComponent();
        }

        private void getCountry(object sender, EventArgs e)
        {
            string companyID;
            int textLength;
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

        private void neukundeVerkauf_Checked(object sender, EventArgs e)
        {
            neukundeVerkauf = Date;
            Console.WriteLine("verkauf: " + neukundeVerkauf);
        }
        private void neukundeEinkauf_Checked(object sender, EventArgs e)
        {
            neukundeEinkauf = Date;
            Console.WriteLine("einkauf: " + neukundeEinkauf);
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
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

            string query = $"INSERT INTO company VALUES ('{companyIDTextBox.Text}', '{companyTextBox.Text}', '{streetTextBox.Text}', '{poBoxTextBox.Text}', '{plzTextBox.Text}', '{cityTextBox.Text}', '{countryTextBox.Text}', '{phoneTextBox.Text}', '{urlTextBox.Text}', '{emailVerkaufTextBox.Text}', '{emailEinkaufTextBox.Text}', '{verkaufKontakt}', '{einkaufKontakt}', '{verkaufBuspro}', '{einkaufBuspro}', '{neukundeVerkauf}', '{neukundeEinkauf}')";
            Console.WriteLine(query);
            db.Update(query);
            Close();
        }

        private void copyMailCheck_CheckStateChanged(object sender, EventArgs e)
        {
            emailEinkaufTextBox.Text = emailVerkaufTextBox.Text;
        }
    }
}
