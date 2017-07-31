using System.Windows.Forms;
using System.ServiceProcess;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using System;
using MySql.Data.MySqlClient;

namespace PendenzenSetuper
{
    public partial class Setuper : Form
    {
        public Setuper()
        {
            InitializeComponent();
            checkMySqlInstalled();
            prefill();
        }

        public void prefill()
        {
            serverTextBox.Text = LocalIPAddress();
        }

        public void checkMySqlInstalled()
        {
            mysqlInstalledCheck.Checked = isServiceIsRunning("mysql");
        }

        public string LocalIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork)
                .ToString();
        }

        protected void createTables(object sender, EventArgs e)
        {
            string script = PendenzenSetuper.Properties.Resources.SQL_Tables;
            string connectionString = "SERVER=" + serverTextBox.Text + ";" + 
                "DATABASE=" + databaseTextBox.Text + ";" + 
                "UID=" + usernameLabel.Text + ";" +
                "PASSWORD=" + passwordTextBox.Text + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(script, connection);
            cmd.ExecuteNonQueryAsync();
        }


        public bool isServiceIsRunning(string serviceName)
        {
            ServiceController mySC = new ServiceController(serviceName);
            if (mySC.Status == ServiceControllerStatus.Running)
            {
                // Service already running
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
