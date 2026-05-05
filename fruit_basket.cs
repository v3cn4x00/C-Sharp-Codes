using System;


namespace Program
{
   class Fruit
   {
       public int count;


       public int TotalFruits(int apples, int mangoes)
       {
           return apples + mangoes;
       }
   }


   class Apples : Fruit
   {
       public Apples()
       {
           Console.Write("Enter number of Apples: ");
           count = int.Parse(Console.ReadLine());
       }
   }


   class Mangoes : Fruit
   {
       public Mangoes()
       {
           Console.Write("Enter number of Mangoes: ");
           count = int.Parse(Console.ReadLine());
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           Apples a = new Apples();
           Mangoes m = new Mangoes();


           Fruit f = new Fruit();
           int total = f.TotalFruits(a.count, m.count);


           Console.WriteLine("Apples: " + a.count);
           Console.WriteLine("Mangoes: " + m.count);
           Console.WriteLine("Total Fruits: " + total);
       }
   }
}
