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
            new MakeConnection();
           // Application.Run(new mainForm());
        }
    }
}