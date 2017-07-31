using System.Data;

namespace Pendenzen
{
    public class DBConnect
    {
        //bool isTunneled = false;
        //SshConnection sshConnection;
        SQLConnection sqlConnection;
        
        public DBConnect()
        {
            /*if (Constants.VERSION == "DEBUG")
            {
                isTunneled = true;
                sshConnection = new SshConnection();
            }
            else
            {
                isTunneled = false;
                sqlConnection = new SQLConnection();
            }*/
            sqlConnection = new SQLConnection();
        }

        public bool Open()
        {
            //if (isTunneled)
            //    return sshConnection.Open();
            //else
                return sqlConnection.Open();
        }

        //Insert statement
        public void Insert(string query)
        {
            //if (isTunneled)
              //  sshConnection.Insert(query);
            //else
                sqlConnection.Insert(query);
        }

        //Update statement
        public void Update(string query)
        {
            //if (isTunneled)
              //  sshConnection.Update(query);
            //else
                sqlConnection.Update(query);
        }

        //Delete statement
        public void Delete(string query)
        {
            //if (isTunneled)
            //    sshConnection.Delete(query);
            //else
                sqlConnection.Delete(query);
        }

        //Select statement
        public DataTable Select(string query)
        {
            //if (isTunneled)
            //    return sshConnection.Select(query);
            //else
                return sqlConnection.Select(query);
        }

        //Count statement
        public int Count(string query)
        {
            //if (isTunneled)
            //    return sshConnection.Count(query);
            //else
                return sqlConnection.Count(query);
        }

        //Backup
        public void Backup()
        {
            //if (isTunneled)
            //    sshConnection.Backup();
            //else
                sqlConnection.Backup();
        }

        //Restore
        public void Restore()
        {
            //if (isTunneled)
            //    sshConnection.Restore();
            //else
                sqlConnection.Restore();
        }
    }
}