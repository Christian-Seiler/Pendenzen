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
    public partial class password : Form
    {
        DBConnect db = new DBConnect();
        Encryption crypt = new Encryption();
        string query = "";

        public password()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            updatePassword();
        }

        private bool hasNewPassword()
        {
            if (neuesPasswort.Text != "")
            {
                if (neuesPasswort.Text == confirmPasswort.Text)
                { return true; }
                else
                {
                    message("Passwort stimmen nicht überein.", "Fehler", MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                message("Bitte neues Passwort eingeben.", "Fehler", MessageBoxIcon.Error);
                return false;
            }
        }

        private bool authenticate()
        {
            query = $"SELECT AdminOption FROM admin WHERE idadmin = 'pass'";
            var passTable = db.Select(query);
            var passRow = passTable.Rows[0];
            object[] passCell = passRow.ItemArray;
            var pass = passCell[0].ToString();


            if (crypt.Encrypt(altesPasswort.Text) == pass)
            {
                return true;
            }
            else
            {
                message("Passwort ungültig", "Fehler", MessageBoxIcon.Error);
                return false;
            }
        }

        private void updatePassword()
        {
            if (authenticate() && hasNewPassword())
            {
                var pass = crypt.Encrypt(neuesPasswort.Text);   
                query = $"UPDATE admin SET AdminOption='{pass}' WHERE idadmin = 'pass'";
                db.Update(query);
                message("Passwort erfolgreich geändert", "Erfolg", MessageBoxIcon.Information);
            }
        }

        private void message(string message, string title, MessageBoxIcon icon)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
            if (result == DialogResult.OK)
            {
                if (title == "Fehler")
                {
                    altesPasswort.Clear();
                    neuesPasswort.Clear();
                    confirmPasswort.Clear();
                }
                else
                {
                    altesPasswort.Clear();
                    neuesPasswort.Clear();
                    confirmPasswort.Clear();
                    this.Close();
                }
            }
        }
    }
}
