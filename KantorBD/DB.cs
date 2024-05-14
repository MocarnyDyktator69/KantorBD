using MySql.Data.MySqlClient;
using System;

namespace KantorBD
{
    internal class DB : IDisposable
    {
        private readonly string connectionString = "server=localhost;port=3306;username=root;password=;database=kantor_db";
        private MySqlConnection connection;

        public DB()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
