using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SingletonPattern
{
    public class SingletonDatabase
    {
        private static SingletonDatabase instance;
        private SqlConnection connection;

        private SingletonDatabase()
        {
            // Private constructor to prevent direct instantiation
            // Simulate the process of establishing a database connection
            string connectionString = "Data Source=GERIMARIZKI;" +
                                      "Initial Catalog=Latihan;" +
                                      "Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static SingletonDatabase GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonDatabase();
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void ExecuteQuery(string query)
        {
            // Code to execute the provided SQL query using the database connection
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteReader(string query)
        {
            // Code to execute the provided SQL query and return a SqlDataReader using the database connection
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteReader();
        }

        // Additional methods for performing database operations can be added here
    }
}
