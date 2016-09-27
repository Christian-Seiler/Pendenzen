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
    public partial class modifyIssue : Form
    {
        public modifyIssue(int id)
        {
            InitializeComponent();
            DBConnect db = new DBConnect();
            string query = $"SELECT * FROM pendenz WHERE idpendenz = {id}";
            DataTable dataTable = db.Select(query);


            List<string> list = new List<string>();
            var i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    list.Add(row.ItemArray[i].ToString());
                    i++;
                }
            }

            

            changeIssueLabel.Text = $"Pendenz #{id} bearbeiten";
            creatorLabel.Text = $"Erfasser: {list[5]}";
            dateLabel.Text = $"Erfasst am: {list[4]}";
            companyBox.Text = list[1];
            referenceTextBox.Text = list[2];
            documentTextBox.Text = list[3];
            responsibleTextBox.Text = list[6];
            //duePicker.Value =  list[7];
            detailsTextBox.Text = list[8];

            //files = list[9]
            //steps = list[10]
            //finalized = list[11]
            //state = list[12]

        }
    }
}
