using System;
namespace Program
{
    public static class Converter
    {
        public static void km_to_m(double km)
        {
            Console.WriteLine($"Miles: {km / 1.609344}");          
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter.km_to_m(5);
        }
    }
}
