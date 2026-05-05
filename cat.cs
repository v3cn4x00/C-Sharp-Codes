using System;
namespace Program
{
    class Cat
    {
        public string name;
        public int age;

        public Cat()
        {
            name = "Unknown";
            age = 0;
        }

        public void display()
        {
            Console.WriteLine($"Cat name is {name} and age is {age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.display();
        }
    }
}
