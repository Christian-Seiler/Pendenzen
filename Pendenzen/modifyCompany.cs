using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class modifyCompany : Form
    {
        private readonly ArrayList _contact = new ArrayList();
        private readonly string _history;
        private readonly string _id;
        private readonly DBConnect db = new DBConnect();

        public modifyCompany(string id)
        {
            InitializeComponent();

            _id = id;

            string query = $"SELECT * FROM company WHERE company_id = '{id}'";

            var table = db.Select(query);
            var contact = new ArrayList(table.Columns.Count);
            foreach (DataRow row in table.Rows)
                foreach (DataColumn column in table.Columns)
                    contact.Add(row[column]);

            _contact = contact;

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
            _history = contact[17].ToString();

            if (contact[11].ToString() == "Ja")
                verkaufKontaktCheck.Checked = true;
            if (contact[12].ToString() == "Ja")
                einkaufKontaktCheck.Checked = true;
            if (contact[13].ToString() == "Ja")
                verkaufBusproCheck.Checked = true;
            if (contact[14].ToString() == "Ja")
                einkaufBusproCheck.Checked = true;
        }

        private string newHistory()
        {
            var historyString = "";
            if (companyIDTextBox.Text != _contact[0].ToString())
            {
                historyString += companyIDTextBox.Text;
                historyString += " ";
            }
            if (companyTextBox.Text != _contact[1].ToString())
            {
                historyString += companyTextBox.Text;
                historyString += " ";
            }
            if (streetTextBox.Text != _contact[2].ToString())
            {
                historyString += streetTextBox.Text;
                historyString += " ";
            }
            if (poBoxTextBox.Text != _contact[3].ToString())
            {
                historyString += poBoxTextBox.Text;
                historyString += " ";
            }
            if (plzTextBox.Text != _contact[4].ToString())
            {
                historyString += plzTextBox.Text;
                historyString += " ";
            }
            if (cityTextBox.Text != _contact[5].ToString())
            {
                historyString += cityTextBox.Text;
                historyString += " ";
            }
            if (countryTextBox.Text != _contact[6].ToString())
            {
                historyString += countryTextBox.Text;
                historyString += " ";
            }
            if (phoneTextBox.Text != _contact[7].ToString())
            {
                historyString += phoneTextBox.Text;
                historyString += " ";
            }
            if (urlTextBox.Text != _contact[8].ToString())
            {
                historyString += urlTextBox.Text;
                historyString += " ";
            }
            if (emailVerkaufTextBox.Text != _contact[9].ToString())
            {
                historyString += emailVerkaufTextBox.Text;
                historyString += " ";
            }
            if (emailEinkaufTextBox.Text != _contact[10].ToString())
            {
                historyString += emailEinkaufTextBox.Text;
                historyString += " ";
            }
            if (historyString != "")
                historyString += "\n";

            historyString += _history;

            return historyString;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var verkaufKontakt = "Nein";
            var einkaufKontakt = "Nein";
            var verkaufBuspro = "Nein";
            var einkaufBuspro = "Nein";
            var neukundeVerkauf = "null";
            var neukundeEinkauf = "null";

            if (verkaufKontaktCheck.Checked)
                verkaufKontakt = "Ja";
            if (einkaufKontaktCheck.Checked)
                einkaufKontakt = "Ja";
            if (verkaufBusproCheck.Checked)
                verkaufBuspro = "Ja";
            if (einkaufBusproCheck.Checked)
                einkaufBuspro = "Ja";
            if (neukundeVerkaufCheck.Checked)
            {
                neukundeVerkauf = DateTime.Now.ToString("yyyy-MM-dd");
                neukundeVerkauf = $"'{neukundeVerkauf}'";
            }
            if (neukundeEinkaufCheck.Checked)
            {
                neukundeEinkauf = DateTime.Now.ToString("yyyy-MM-dd");
                neukundeEinkauf = $"'{neukundeEinkauf}'";
            }

            var history = $"{DateTime.Now.ToString("dd. MMM. yy HH:mm")} {person.getUserFullName()}\n" + newHistory();

            string query =
                $"UPDATE company SET company_name='{companyTextBox.Text.Replace("'", "''")}', company_street='{streetTextBox.Text}', company_pobox='{poBoxTextBox.Text}', company_plz='{plzTextBox.Text}', company_city='{cityTextBox.Text.Replace("'", "''")}', company_country='{countryTextBox.Text}', company_phone='{phoneTextBox.Text}', company_website='{urlTextBox.Text}', company_verkaufmail='{emailVerkaufTextBox.Text}', company_einkaufmail='{emailEinkaufTextBox.Text}', company_verkaufkontakt='{verkaufKontakt}', company_einkaufkontakt='{einkaufKontakt}', company_verkaufBuspro='{verkaufBuspro}', company_einkaufBuspro='{einkaufBuspro}', company_sellersince = {neukundeVerkauf}, company_clientsince = {neukundeEinkauf}, company_history = '{history.Replace("'", "''")}' WHERE company_id = '{_id}'";
            db.Update(query);
            Close();
        }
    }
}