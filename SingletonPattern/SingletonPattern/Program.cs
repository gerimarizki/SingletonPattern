
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Singleton singletonMethod1 = Singleton.getInstance();

            //Console.WriteLine("Input Angka");
            //int number = Int32.Parse(Console.ReadLine());
            //string result = singletonMethod1.EvenOddCheck(number);
            //Console.WriteLine(result);

            //Singleton singletonMethod2 = Singleton.getInstance();

            //Console.WriteLine("Input Angka");
            //int limitAngka = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("==================================");
            //Console.WriteLine("genap/ganjil");
            //string choice = Console.ReadLine();
            //singletonMethod2.PrintEvenOdd(limitAngka, choice);

            //Console.WriteLine(singletonMethod2);


            //Singleton singletonMethod3 = Singleton.getInstance();

            //Singleton singletonMethod4 = Singleton.getInstance();

            //Console.WriteLine(singletonMethod3 == singletonMethod4);


            var connection = SingletonDatabase.GetInstance();


            // Use the database connection for executing queries
            string query = "INSERT INTO regions (name) VALUES ('dimana nih');";
            connection.ExecuteQuery(query);

            query = "SELECT * FROM regions";
            SqlDataReader reader = connection.ExecuteReader(query);

            // Read the results from the SqlDataReader
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                Console.WriteLine($"Name: {name}");
            }

            reader.Close();

        }

    }
}
