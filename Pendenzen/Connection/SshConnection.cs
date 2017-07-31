using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

/*namespace Pendenzen
{
    class SshConnection
    {
        private string database;
        private string password;
        private string server;
        private string uid;
        private string sshServer;
        private string sshPassword;
        private string sshUid;
        private uint remotePort = 3304;
        // private int localPort;
        //private SshClient client;
        private SshTunnel tunnel;
        private MySqlConnection connection;

        public SshConnection()
        {
            Initialize();
        }
        
        private void Initialize()
        {
            // MySQL
            database = "db351322_541";
            uid = "db351322_541";
            password = "Chris1987";
            // SSH
            sshServer = "134.119.225.234";
            sshPassword = "Chris1987";
            sshUid = "ssh-438911-christian";

            //ConnectionInfo sshci = new ConnectionInfo(sshServer, sshUid, new PasswordAuthenticationMethod(sshUid, sshPassword));
            MySqlConnectionStringBuilder cs = new MySqlConnectionStringBuilder()
            {
                AllowBatch = true,
                Server = "127.0.0.3",
                Database = database,
                UserID = uid,
                Password = password
            };
            //tunnel = new SshTunnel(sshci, remotePort);
            cs.Port = (uint)tunnel.LocalPort;
            connection = new MySqlConnection(cs.GetConnectionString(true));
            
        }

        public bool Open()
        {
            return OpenConnection();
        }
        

        //open connection to database
        private bool OpenConnection()
        {
            client = new SshClient(sshServer, sshUid, sshPassword);
            client.Connect();
            Debug.WriteLine(client.ConnectionInfo.ServerVersion);
            return client.IsConnected;
        }

        //Close connection
        private bool CloseConnection()
        {
            client.Disconnect();
            return client.IsConnected;
        }

        //Insert statement
        public void Insert(string query)
        {
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        public DataTable Select(string query)
        {
            if (OpenConnection())
            {
                Debug.WriteLine("query: " + query);

                var cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                //CloseConnection();
                return dTable;
            }
            return null;
        }

        //Count statement
        public int Count(string query)
        {
            var count = -1;
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, connection);
                count = int.Parse(cmd.ExecuteScalar() + "");
                CloseConnection();
            }
            return count;
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
*/