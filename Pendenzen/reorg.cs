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
        string query = "";
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
                }
                else
                {
                    query = $"DELETE FROM pendenz WHERE erfasst_am < '{date}'";
                }

                db.Delete(query);
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
            query = $"SELECT adminpass FROM admin";
            var passTable = db.Select(query);
            var passRow = passTable.Rows[0];
            object[] passCell = passRow.ItemArray;


            var pass = passCell[0].ToString();

            if (passwordBox.Text == pass)
            {
                Console.WriteLine("Password correct!");
                return true;
            }
            else
            {
                Console.WriteLine("Password false!");
                return false;
            }



        }
    }
}
