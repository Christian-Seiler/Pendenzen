using System;
using System.Collections;
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
    public partial class modifyCompany : Form
    {
        DBConnect db = new DBConnect();

        string _id;

        public modifyCompany(string id)
        {
            InitializeComponent();

            _id = id;

            string query = $"SELECT * FROM company WHERE company_id = '{id}'";

            DataTable table = db.Select(query);
            ArrayList contact = new ArrayList(table.Columns.Count);
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    contact.Add(row[column]);
                }
            }

            companyIDTextBox.Text = contact[0].ToString();
            companyTextBox.Text = contact[1].ToString();
            streetTextBox.Text = contact[2].ToString();
            poBoxTextBox.Text = contact[3].ToString();
            plzTextBox.Text = contact[4].ToString();
            cityTextBox.Text = contact[5].ToString();
            countryTextBox.Text = contact[6].ToString();
            phoneTextBox.Text = contact[7].ToString();
            urlTextBox.Text = contact[8].ToString();
            emailVerkaufTextBox.Text = contact[9].ToString();
            emailEinkaufTextBox.Text = contact[10].ToString();

            if (contact[11].ToString() == "Ja")
            {
                verkaufKontaktCheck.Checked = true;
            }
            if (contact[12].ToString() == "Ja")
            {
                einkaufKontaktCheck.Checked = true;
            }
            if (contact[13].ToString() == "Ja")
            {
                verkaufBusproCheck.Checked = true;
            }
            if (contact[14].ToString() == "Ja")
            {
                einkaufBusproCheck.Checked = true;
            }
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
                Console.WriteLine("verkaufKontakt Ja");
            }
            if (einkaufKontaktCheck.Checked)
            {
                einkaufKontakt = "Ja";
                Console.WriteLine("einkaufKontakt Ja");
            }
            if (verkaufBusproCheck.Checked)
            {
                verkaufBuspro = "Ja";
                Console.WriteLine("verkaufBuspro Ja");
            }
            if (einkaufBusproCheck.Checked)
            {
                einkaufBuspro = "Ja";
                Console.WriteLine("einkaufBuspro Ja");
            }

            string query = $"UPDATE company SET company_name='{companyTextBox.Text}', company_street='{streetTextBox.Text}', company_pobox='{poBoxTextBox.Text}', company_plz='{plzTextBox.Text}', company_city='{cityTextBox.Text}', company_country='{countryTextBox.Text}', company_phone='{phoneTextBox.Text}', company_website='{urlTextBox.Text}', company_verkaufmail='{emailVerkaufTextBox.Text}', company_einkaufmail='{emailEinkaufTextBox.Text}', company_verkaufkontakt='{verkaufKontakt}', company_einkaufkontakt='{einkaufKontakt}', company_verkaufBuspro='{verkaufBuspro}', company_einkaufBuspro='{einkaufBuspro}' WHERE company_id = '{_id}'";
            Console.WriteLine(query);
            db.Update(query);
            Close();
        }
    }
}
