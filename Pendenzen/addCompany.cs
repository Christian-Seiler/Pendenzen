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
    public partial class addCompany : Form
    {
        public addCompany()
        {
            InitializeComponent();
        }

        private void getCounty(object sender, EventArgs e)
        {
            string companyID;
            int textLength;
            if (companyIDTextBox.TextLength == 3)
            {
                companyID = $"CH-{companyIDTextBox.Text}";
                textLength = 6;
            }
            else
            {
                textLength = companyIDTextBox.TextLength;
                companyID = companyIDTextBox.Text;
            }

            string query = $"SELECT * FROM country WHERE idcountry='{companyID.Remove(textLength - 4)}'";
            DBConnect db = new DBConnect();


            List<string> list = new List<string>();
            var i = 0;
            DataTable data = db.Select(query);
            foreach (DataRow row in data.Rows)
            {
                foreach (DataColumn col in data.Columns)
                {
                    list.Add(row.ItemArray[i].ToString());
                    i++;
                }
            }

            countryTextBox.Text = list[1];
        }



















        private void submitButton_Click(object sender, EventArgs e)
        {
            string writeQuery = $"Insert INTO company (company_id, company_name) VALUES ('{companyIDTextBox.Text}', '{companyTextBox.Text}')";
            DBConnect db = new DBConnect();
            db.Insert(writeQuery);

            this.Close();
        }
    }
}
