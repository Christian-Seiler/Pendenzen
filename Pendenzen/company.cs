using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class Firmendetails : Form
    {

        DBConnect db = new DBConnect();

        DataTable _table;

        public Firmendetails(string id)
        {
            InitializeComponent();
            _table = db.Select($"SELECT * FROM company WHERE company_id = '{id}'");
            makeData(_table);
        }

        private void makeData(DataTable table)
        {
            ArrayList contact = new ArrayList(table.Columns.Count);
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    contact.Add(row[column]);
                }
            }

            idLabel.Text = contact[0].ToString();
            companyLabel.Text = contact[1].ToString();
            companyBigLabel.Text = $"{companyLabel.Text} ({idLabel.Text})";
            streetLabel.Text = contact[2].ToString();
            poBoxLabel.Text = contact[3].ToString();
            plzLabel.Text = contact[4].ToString();
            cityLabel.Text = contact[5].ToString();
            countryLabel.Text = contact[6].ToString();
            phoneLabel.Text = contact[7].ToString();
            urlLabel.Text = contact[8].ToString();
            emailVerkaufLabel.Text = contact[9].ToString();
            emailEinkaufLabel.Text = contact[10].ToString();

            manageButtons();
        }

        private void manageButtons()
        {
            if (urlLabel.Text == "")
            {
                openLinkButton.Visible = false;
                webLabel.Visible = false;
            }
            else
            {
                openLinkButton.Visible = true;
                webLabel.Visible = true;
            }
            if (emailVerkaufLabel.Text == "")
            {
                verkaufEmailButton.Visible = false;
                verkaufLabel.Visible = false;

            }
            else
            {
                verkaufEmailButton.Visible = true;
                verkaufLabel.Visible = true;
            }
            if (emailEinkaufLabel.Text == "")
            {
                einkaufEmailButton.Visible = false;
                einkaufLabel.Visible = false;
            }
            else
            {
                einkaufEmailButton.Visible = true;
                einkaufLabel.Visible = true;
            }
        }

        private void companyChangeLabel_Click(object sender, EventArgs e)
        {
            modifyCompany modifyCompany = new modifyCompany(idLabel.Text);
            Close();
            modifyCompany.ShowDialog();

        }

        private void openLinkButton_Click(object sender, EventArgs e)
        {
            Process.Start(urlLabel.Text);
        }

        private void verkaufEmailButton_Click(object sender, EventArgs e)
        {
            Process.Start($"mailto:{emailVerkaufLabel.Text}");
        }

        private void einkaufEmailButton_Click(object sender, EventArgs e)
        {
            Process.Start($"mailto:{emailEinkaufLabel.Text}");
        }
    }
}