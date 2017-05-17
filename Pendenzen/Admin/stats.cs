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
    public partial class Stats : Form
    {
        DBConnect db = new DBConnect();

        public Stats()
        {
            InitializeComponent();

            var thisMonth = DateTime.Today.ToString("yyyy-MM-01");
            var lastMonth = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-01");

            offen.Text = db.Count($"SELECT COUNT(*) FROM pendenz WHERE state='open' {admin()}").ToString();

            geschlossenAktuell.Text = db.Count($"SELECT COUNT(*) FROM pendenz WHERE state='done' AND finalized >= '{thisMonth}' {admin()}").ToString();
            storniertAktuell.Text = db.Count($"SELECT COUNT(*) FROM pendenz WHERE state='cancelled' AND finalized >= '{thisMonth}' {admin()}").ToString();
            totalAktuell.Text = db.Count($"SELECT COUNT(*) FROM pendenz WHERE erfasst_am >= '{lastMonth}' {admin()}").ToString();

            geschlossenLetzt.Text = db.Count($"SELECT COUNT(*) FROM pendenz WHERE state='done' AND finalized < '{thisMonth}' AND finalized >= '{lastMonth}' {admin()}").ToString();
            storniertLetzt.Text = db.Count($"SELECT COUNT(*) FROM pendenz WHERE state='cancelled' AND finalized < '{thisMonth}' AND finalized >= '{lastMonth}' {admin()}").ToString();
            totalLetzt.Text = db.Count($"SELECT COUNT(*) FROM pendenz WHERE erfasst_am < '{thisMonth}' AND erfasst_am >= '{lastMonth}' {admin()}").ToString();

            title.Text = $"Statistik {dept()}";
        }

        private string dept()
        {
            if (Person.getInfo()[4] == "Informatik" || Person.getInfo()[4] == "GL")
            {
                return "aller Abteilungen";
            }
            else
            {
                return $"{Person.getInfo()[4]}";
            }
        }

        private string admin()
        {
            if (Person.getInfo()[4] == "Informatik" || Person.getInfo()[4] == "GL")
            {
                return "";
            }
            else
            {
                return $"AND department = '{Person.getInfo()[4]}'";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
