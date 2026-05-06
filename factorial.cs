using System;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a whole number to find it's factorial: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your factorial is: {factorial(num)}");
        }

        static int factorial(int num)
        {
            if (num == 1)
            {
                return num;
            }
            else
            {
                return num * factorial(num - 1);
            }
        }
    }
}