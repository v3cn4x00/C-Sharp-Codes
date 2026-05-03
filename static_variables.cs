using System;
namespace Program
{
    class Counter
    {
        public static int count = 0;

        public Counter()
        {
            count++;
            Console.WriteLine($"{count}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter();
            Counter c2 = new Counter();
        }
    }
}
