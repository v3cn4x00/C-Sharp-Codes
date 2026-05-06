using System;
namespace Program
{
    class Vehicle
    {
        private string? make;
        private int year;
        private int speed;

        public string Make { get { return make; } set { make = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.Make = "Honda"; v1.Year = 1900; v1.Speed = 150;

            Vehicle v2 = new Vehicle();
            v2.Make = "BMW"; v2.Year = 2014; v2.Speed = 249;

            Vehicle v3 = new Vehicle();
            v3.Make = "Lamborghini"; v3.Year = 2025; v3.Speed = 350;

            Console.WriteLine(v1.Make + " " + v1.Year + " " + v1.Speed);
            Console.WriteLine(v2.Make + " " + v2.Year + " " + v2.Speed);
            Console.WriteLine(v3.Make + " " + v3.Year + " " + v3.Speed);
        }
    }
}