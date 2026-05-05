using System;
using System.Dynamic;
namespace Program
{
   class Person
   {
       public string name {get; set;}
       public int age {get; set;}
       public string address {get; set;}


       public virtual void ShowDetails()
       {
           Console.WriteLine($"Name: {name}");
           Console.WriteLine($"Age: {age}");
           Console.WriteLine($"Address: {address}");
       }
   }


   class Student : Person
   {
       public char grade = 'A';
       public string school_id = "ASD-852";


       public override void ShowDetails()
       {
           Console.WriteLine("----Student Data----");
           base.ShowDetails();
           Console.WriteLine($"Grade: {grade}");
           Console.WriteLine($"School ID: {school_id}");
       }
   }


   class Teacher : Person
   {
       public string subject = "OOPs";
       public string employee_id = "ABC-123";


       public override void ShowDetails()
       {
           Console.WriteLine("----Teacher Data----");
           base.ShowDetails();
           Console.WriteLine($"Subject: {subject}");
           Console.WriteLine($"Employee ID: {employee_id}");
       }
   }


   class Staff : Person
   {
       public string department = "Software Engineer";
       public int shift = 3;


       public override void ShowDetails()
       {
           Console.WriteLine("----Staff Data----");
           base.ShowDetails();
           Console.WriteLine($"Department: {department}");
           Console.WriteLine($"Shift: {shift}");
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           Person s1 = new Student();
           Person t1 = new Teacher();
           Person a1 = new Staff();
           s1.name = "Steve"; s1.age = 19; s1.address = "123 lane Boulevard Avenue California";
           t1.name = "Kevin"; t1.age = 56; t1.address = "99 lane Ave 3 California";
           a1.name = "David"; a1.age = 44; a1.address = "22 lane Pete road California";


           s1.ShowDetails();
           t1.ShowDetails();
           a1.ShowDetails();
       }
   }
