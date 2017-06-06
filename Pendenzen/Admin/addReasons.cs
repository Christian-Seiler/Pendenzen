using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendenzen.Admin
{
    public partial class addReasons : Form
    {
        DBConnect db;
        public addReasons()
        {
            db = new DBConnect();
            InitializeComponent();
            getDepartment();
            getReasons();
        }

        private void getDepartment()
        {
            String query = "SELECT department FROM reason GROUP BY department";
            DataTable dataTable = db.Select(query);
            foreach (DataRow row in dataTable.Rows)
                departmentBox.Items.Add(row[0]);
        }

        private void getReasons()
        {
            String query = "SELECT department, description FROM reason ORDER BY department";
            DataTable dataTable = db.Select(query);
            StringBuilder s = new StringBuilder();
            foreach (DataRow row in dataTable.Rows)
            {
                s.AppendLine(row[0] + " - " + row[1]);
            }
            label.Text = s.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            String query = $"Insert Into reason (description, department) SET ('{textBox.Text}', '{departmentBox.Text}')";
            db.Insert(query);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
