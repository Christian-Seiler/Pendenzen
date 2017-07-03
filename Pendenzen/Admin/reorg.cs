using System;
using System.Windows.Forms;

namespace Pendenzen
{
    public partial class reorganisation : Form
    {
        private string count = "";
        private readonly Encryption crypt = new Encryption();
        private string date;

        private readonly DBConnect db = new DBConnect();
        private string query = "";

        public reorganisation()
        {
            InitializeComponent();

            string[] months = {"3", "6", "9", "12"};
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
        }

        private void dateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            date = DateTime.Now.AddMonths(-int.Parse(dateBox.Text)).ToString("yyyy-MM-dd HH:mm:ss");
        }

        private bool authenticate()
        {
            query = $"SELECT AdminOption FROM admin WHERE idadmin = 'pass'";
            String pass = db.Select(query).Rows[0].ItemArray[0].ToString();
            
            if (crypt.encrypt(passwordBox.Text) == pass)
                return true;
            return false;
        }
    }
}