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

        public modifyCompany(string id)
        {
            InitializeComponent();

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
            verkaufKontaktCheck.Checked = (bool)contact[11];
            einkaufKontaktCheck.Checked = (bool)contact[12];
            verkaufBusproCheck.Checked = (bool)contact[13];
            einkaufBusproCheck.Checked = (bool)contact[14];

        }
    }
}
