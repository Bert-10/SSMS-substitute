using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SSMS_interface
{
    public class DataBase
    {
        SqlConnection sqlConnection;
        public Boolean openConnection(string serverName, string dbName, string userID,string userPassword)
        {
            var connected = true;
            sqlConnection = new SqlConnection($@"Data Source='{serverName}'; Initial Catalog='{dbName}';User ID='{userID}'; Password='{userPassword}'");
            
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    sqlConnection.Open();
                }
                catch {
                    connected = false;
                   // Console.WriteLine("wrong password or user id");
                }
            }
            return connected;
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection() 
        {
            return sqlConnection;
        }
    }
}
