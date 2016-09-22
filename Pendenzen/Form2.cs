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

        private void submitButton_Click(object sender, EventArgs e)
        {
            string searchQuery = $"SELECT * FROM suplier WHERE suplier_id = {companyIDTextBox.Text}";
 //           string writeQuery = $"";
            sql.connection(searchQuery);
        }
    }
}
