using System;
using System.Runtime.InteropServices.Marshalling;
namespace Program
{
   class Vehicle
   {
       public string brand;
       public int speed;
       public string fueltype;


       public virtual void displayinfo()
       {
           Console.WriteLine($"Brand: {brand}");
           Console.WriteLine($"Speed: {speed}");
           Console.WriteLine($"FuelType: {fueltype}");
       }
   }


   class Car : Vehicle
   {
       public int num_of_seats;
       public override void displayinfo()
       {
           Console.WriteLine("----Car Design----");
           base.displayinfo();
           Console.WriteLine($"Number of Seats: {num_of_seats}");
       }
   }


   class Bike : Vehicle
   {
       public bool helmetincluded;
       public override void displayinfo()
       {
           Console.WriteLine("----Bike Design----");
           base.displayinfo();
           Console.WriteLine($"Helmet Included: {helmetincluded}");
       }
   }


   class Truck : Vehicle
   {
       public int cargo_capacity;
       public override void displayinfo()
       {
           Console.WriteLine("----Truck Design----");
           base.displayinfo();
           Console.WriteLine($"Cargo Capacity: {cargo_capacity} kg");
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           Car c1 = new Car();
           Bike b1 = new Bike();
           Truck t1 = new Truck();


           c1.brand = "BMW"; c1.speed = 300; c1.fueltype = "Electric"; c1.num_of_seats = 2;
           b1.brand = "Trek"; b1.speed = 250; b1.fueltype = "HEVs"; b1.helmetincluded = true;
           t1.brand = "Volvo"; t1.speed = 150; t1.fueltype = "Premium Diesel"; t1.cargo_capacity = 1500;
           c1.displayinfo(); b1.displayinfo(); t1.displayinfo();


       }
   }
}
