using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Pendenzen
{
   public class SQLConnection
   {
        private MySqlConnection connection;
        private string database;
        private string password;
        private string server;
        private string uid;

        //Constructor
        public SQLConnection()
        {
            Initialize();
        }
        
        //Initialize values
        private void Initialize()
        {
            server = "192.168.0.2";
            database = "pendenzen";
            uid = "pendenzen";
            password = "pendenzen";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool Open()
        {
            return OpenConnection();
        }
        
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // When handling errors, you can your application's response based 
                // on the error number.
                // The two most common error numbers when connecting are as follows:
                // 0: Cannot connect to server.
                // 1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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
                Debug.WriteLine(query);
                // Open connection
                if (OpenConnection())
                {
                    // Create Command
                    var cmd = new MySqlCommand(query, connection);

                    // Create a data reader and Execute the command
                    var adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    var dTable = new DataTable();
                    adapter.Fill(dTable);

                    //close connection
                CloseConnection();

                    //return DataTable to be displayed
                    return dTable;
                }
                return null;
            }

            //Count statement
            public int Count(string query)
            {
                var count = -1;

                //Open Connection
                if (OpenConnection())
                {
                    // Create Command
                    var cmd = new MySqlCommand(query, connection);
                    //ExecuteScalar will return one Value
                    count = int.Parse(cmd.ExecuteScalar() + "");
                    //close connection
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