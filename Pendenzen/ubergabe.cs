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
    public partial class ubergabe : Form
    {
        DBConnect db = new DBConnect();

        public ubergabe()
        {
            InitializeComponent();
            if (isAdmin())
            {
                ubergabeBox.ResetText();
                ubergabeBox.Enabled = true;
            }
            else
            {
                ubergabeBox.Text = person.getInfo()[0];
                ubergabeBox.Enabled = false;
            }

            var list = new List<string>();
            var query = "SELECT sachbearbeiter FROM pendenz";
            var dataTable = db.Select(query);
            foreach (DataRow row in dataTable.Rows)
                if (!ubergabeBox.Items.Contains(row[0]))
                    ubergabeBox.Items.Add(row[0]);
        }

        private bool isAdmin()
        {
            if (person.getInfo()[4] == "Informatik" || person.getInfo()[4] == "GL")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ubergabeBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var query = $"UPDATE pendenz SET sachbearbeiter = '{ubernameBox.Text.ToUpper()}' WHERE sachbearbeiter = '{ubergabeBox.Text}'";
            db.Update(query);
            Close();
        }

        private void ubernameBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }


        private void validate()
        {
            var count = db.Count($"SELECT COUNT(*) FROM pendenz WHERE sachbearbeiter = '{ubergabeBox.Text}'");
            if (count > 0)
            {
                okButton.Text = $"OK ({count})";
                if (ubernameBox.TextLength >= 3)
                {
                    okButton.Enabled = true;
                }
                else
                {
                    okButton.Enabled = false;
                }
            }
            else
            {
                okButton.Text = "OK";
                okButton.Enabled = false;
            }
        }
    }
}
