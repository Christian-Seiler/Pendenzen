using System.Windows.Forms;

namespace Pendenzen
{
    public class MakeConnection
    {
        public MakeConnection()
        {
            if (new DBConnect().Open())
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