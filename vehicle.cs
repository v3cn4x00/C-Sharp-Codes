using System;
namespace Program
{
    class Vehicle
    {
        private string make;
        private int year;
        private int speed;

        public string GetMake() { return make; }
        public int GetYear() { return year; }
        public int GetSpeed() { return speed; }
        public void SetMake(string m) { make = m; }
        public void SetYear(int y) { year = y; }
        public void SetSpeed(int s) { speed = s; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.SetMake("Honda"); v1.SetYear(1900); v1.SetSpeed(150);

            Vehicle v2 = new Vehicle();
            v2.SetMake("BMW"); v2.SetYear(2014); v2.SetSpeed(249);

            Vehicle v3 = new Vehicle();
            v3.SetMake("Lamborghini"); v3.SetYear(2025); v3.SetSpeed(350);

            Console.WriteLine(v1.GetMake() + " " + v1.GetYear() + " " + v1.GetSpeed());
            Console.WriteLine(v2.GetMake() + " " + v2.GetYear() + " " + v2.GetSpeed());
            Console.WriteLine(v3.GetMake() + " " + v3.GetYear() + " " + v3.GetSpeed());
        }
    }
}