using System.Windows.Forms;

namespace Pendenzen
{
    public class MakeConnection
    {
        public MakeConnection()
        {

            DBConnect db = new DBConnect();
            if (db.Open())
            {
                Application.Run(new mainForm());
            }
            else
            {
                MessageBox.Show("Cannot connect to server. Please contact administrator");
            }
        }
    }
}