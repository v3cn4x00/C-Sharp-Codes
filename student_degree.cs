using System;
namespace Program
{
   class Student
   {
       public int s_num;
       public string s_name;
       public double s_avg;


       public Student(int s_num, string s_name, double s_avg)
       {
           this.s_num = s_num;
           this.s_name = s_name;
           this.s_avg = s_avg;
       }


       public void SetNum(int s_num)
       {
           this.s_num = s_num;         
       }


       public int GetNum()
       {
           return s_num;
       }


       public void SetName(string s_name)
       {
           this.s_name = s_name;
       }


       public string GetName()
       {
           return s_name;
       }


       public void SetAvg(double s_avg)
       {
           this.s_avg = s_avg;
       }


       public double GetAvg()
       {
           return s_avg;
       }


       public virtual void DisplayInfo()
       {
           Console.WriteLine($"Student number: {s_num}\nStudent Name: {s_name}\nStudent Average: {s_avg}");
       }
   }


   class graduateStudent : Student
   {
       public int level;
       public int year;
       public graduateStudent(int s_num, string s_name, double s_avg, int level, int year) : base(s_num, s_name, s_avg)
       {
           this.level = level;
           this.year = year;
       }


       public void SetLevel(int level)
       {
           this.level = level;
       }
       public int GetLevel()
       {
           return level;
       }


       public void SetYear(int year)
       {
           this.year = year;
       }


       public int GetYear()
       {
           return year;
       }


       public override void DisplayInfo()
       {
           base.DisplayInfo();
           Console.WriteLine($"Level: {level}\nYear: {year}");
       }
   }


   class masterStudent : graduateStudent
   {
       public int newid;
       public masterStudent(int s_num, string s_name, double s_avg, int level, int year, int newid) : base(s_num, s_name, s_avg,level,year)
       {
           this.newid = newid;
       }


       public void SetID(int newid)
       {
           this.newid = newid;
       }


       public int GetID()
       {
           return newid;
       }


       public override void DisplayInfo()
       {
           base.DisplayInfo();
           Console.WriteLine($"New ID: {newid}");
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           Student s1 = new Student(5, "Gale", 80.2);
           s1.DisplayInfo();
           masterStudent m1 = new masterStudent(8, "Woz", 93.55, 8, 2, 44582);
           m1.DisplayInfo();
       }
   }
}
