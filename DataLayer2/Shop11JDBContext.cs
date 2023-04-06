using System;
using System.Data.SqlClient;

// Install:
// System.Data.SqlClient

namespace DataLayer2
{
    public class Shop11JDBContext : IDisposable
    {
        private readonly string connectionString;
        private SqlConnection Connection;
        private SqlCommand Command;

        public Shop11JDBContext()
        {
            connectionString = "Server=LAPTOP-AT94SBBO\\SQLEXPRESS; Database = ShopDb11J; Trusted_Connection = True;";
            Connection = new SqlConnection(connectionString);
        }

        public Shop11JDBContext(string connectionString)
        {
            this.connectionString = connectionString;
            Connection = new SqlConnection(connectionString);
        }

        public void CreateCommand(string query)
        {
            // If someone calls CreateCommand() but not ExecuteMethods, we want to clear the memory containing previous command!
            if (Command != null)
            {
                Command.Dispose();
            }

            Command = new SqlCommand(query, Connection);
        }

        public object ExecuteScalar(params SqlParameter[] parameters)
        {
            // SQL query can have literals!
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    Command.Parameters.Add(parameter);
                }
            }

            Connection.Open();
            object result = Command.ExecuteScalar();
            return result;
        }

        public SqlDataReader ExecuteReader(params SqlParameter[] parameters)
        {
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    Command.Parameters.Add(parameter);
                }
            }

            Connection.Open();
            return Command.ExecuteReader();
        }

        public int ExecuteNonQuery(params SqlParameter[] parameters)
        {
            // SQL query can have literals!
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    Command.Parameters.Add(parameter);
                }
            }

            Connection.Open();
            int result = Command.ExecuteNonQuery();
            return result;
        }

        public void CloseConnection()
        {
            Command.Dispose();
            Connection.Close();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
