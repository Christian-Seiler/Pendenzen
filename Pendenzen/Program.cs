using System;
using System.Windows.Forms;

namespace Pendenzen
{
    internal static class Program
    {
        /// <summary>
        ///     Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBConnect db = new DBConnect();
            if (db.Open()) {
                Application.Run(new mainForm());
            }
            else
            {
                MessageBox.Show("Cannot connect to server.  Contact administrator");
            }
        }
    }
}