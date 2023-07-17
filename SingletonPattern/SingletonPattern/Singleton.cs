using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        {
            // Private constructor to prevent direct instantiation
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Additional methods and properties can be added here


        public string EvenOddCheck(int number)
        {
            if (number % 2 == 0)
            {
                return "Bilangan " + number + " adalah angka genap.";
            }
            else
            {
                return "Bilangan " + number + " adalah angka ganjil.";
            }
        }

        public void PrintEvenOdd(int limit, string choice)
        {

            Console.WriteLine("Bilangan " + choice + ":");

            for (int i = 1; i <= limit; i++)
            {
                if (choice == "genap" && i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                else if (choice == "ganjil" && i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
