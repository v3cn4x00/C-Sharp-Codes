using System;
namespace Program
{
   class Marks
   {
       protected static int counter = 0;
       public int roll_num;
       public string name;
       public double marks;


       public Marks()
       {
           counter++;
           roll_num = counter;
       }
   }


   class Physics : Marks
   {
      
   }


   class Chemistry : Marks
   {
      
   }


   class Mathematics : Marks
   {
      
   }


   class Program
   {
       static void Main(string[] args)
       {
           Console.Write("Enter number of students: ");
           int num = Convert.ToInt32(Console.ReadLine());


           Physics[] phy = new Physics[num];
           Chemistry[] chem = new Chemistry[num];
           Mathematics[] maths = new Mathematics[num];


           for (int i = 0; i < num; i++)
           {
               phy[i] = new Physics();
               chem[i] = new Chemistry();
               maths[i] = new Mathematics();


               Console.Write($"Enter name of student {i + 1}: ");
               phy[i].name = Console.ReadLine();


               Console.Write("Enter the marks for subject Physics: ");
               phy[i].marks = Convert.ToDouble(Console.ReadLine());


               Console.Write("Enter the marks for subject Chemistry: ");
               chem[i].marks = Convert.ToDouble(Console.ReadLine());


               Console.Write("Enter the marks for subject Mathematics: ");
               maths[i].marks = Convert.ToDouble(Console.ReadLine());
           }


           double classtotal = 0;


           for (int i = 0; i < num; i++)
           {
               double total = phy[i].marks + chem[i].marks + maths[i].marks;
               classtotal += total;


               Console.WriteLine($"\nRoll No: {phy[i].roll_num}");
               Console.WriteLine($"Name: {phy[i].name}");
               Console.WriteLine($"Physics: {phy[i].marks}");
               Console.WriteLine($"Chemistry: {chem[i].marks}");
               Console.WriteLine($"Mathematics: {maths[i].marks}");
               Console.WriteLine($"Total: {total}");
           }


           double average = classtotal / num;
           Console.WriteLine($"\nClass Average: {average}");
       }
   }
}
