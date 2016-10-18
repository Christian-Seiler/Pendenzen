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
    public partial class reorganisation : Form
    {

        DBConnect db = new DBConnect();
        Encryption crypt = new Encryption();
        string query = "";
        string count = "";
        string date;

        public reorganisation()
        {
            InitializeComponent();

            string[] months = { "3", "6", "9", "12" };
            dateBox.Items.AddRange(months);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (authenticate())
            {
                if (openOnly.Checked)
                {
                    query = $"DELETE FROM pendenz WHERE erfasst_am < '{date}' AND state = 'done'";
                    count = $"SELECT COUNT(*) FROM pendenz WHERE erfasst_am < '{date}' AND state = 'done'";
                }
                else
                {
                    query = $"DELETE FROM pendenz WHERE erfasst_am < '{date}'";
                    count = $"SELECT COUNT(*) FROM pendenz WHERE erfasst_am < '{date}'";
                }
                if (db.Count(count) > 0)
                {
                    infoLabel.Text = $"{db.Count(count)} Datensätze gelöscht.";
                    infoLabel.Visible = true;
                    db.Delete(query);
                }
                else
                {
                    infoLabel.Text = $"Keide Datensätze zu löschen.";
                    infoLabel.Visible = true;
                }

            }
            else {
            }
        }

        private void dateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = DateTime.Now.AddMonths(-Int32.Parse(dateBox.Text)).ToString("yyyy-MM-dd HH:mm:ss");
        }

        private bool authenticate ()
        {
            query = $"SELECT AdminOption FROM admin WHERE idadmin = 'pass'";
            var passTable = db.Select(query);
            var passRow = passTable.Rows[0];
            object[] passCell = passRow.ItemArray;

            var pass = passCell[0].ToString();


            if (crypt.Encrypt(passwordBox.Text) == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
