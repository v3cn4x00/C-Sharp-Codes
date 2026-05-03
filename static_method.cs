using System;
namespace Program
{
    class MathHelper
    {
        public static int square(int n)
        {
            return n * n;
        }

        public static int cube(int n)
        {
            return n * n * n;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square: {MathHelper.square(5)}");
            Console.WriteLine($"Cube: {MathHelper.cube(5)}");
        }
    }
}
