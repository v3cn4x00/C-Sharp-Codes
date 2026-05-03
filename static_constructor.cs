using System;
namespace Program
{
    class Database
    {
        public static string? connectionString;
        static Database()
        {
            Console.WriteLine("Static Constructor called once!");
            connectionString = "Connection: Server=localhost;DB=mydb";
            Console.WriteLine($"{connectionString}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Database d1 = new Database();
            Console.WriteLine("Onject 1 created");
            Database d2 = new Database();
            Console.WriteLine("Object 2 created");
        }
    }
}
