using System;
using System.Dynamic;
namespace Program
{
   class Date
   {
       private int day;
       private int month;
       private int year;




       public Date(int day, int month, int year)
       {
           this.day = day;
           this.month = month;
           this.year = year;
       }


       public int getDay()
       {
           return day;
       }


       public int getMonth()
       {
           return month;
       }


       public int getYear()
       {
           return year;
       }


       public void setDay(int day)
       {
           this.day = day;
       }


       public void setMonth(int month)
       {
           this.month = month;
       }


       public void setYear(int year)
       {
           this.year = year;
       }


       public void setDate(int day, int month, int year)
       {
           this.day = day;
           this.month = month;
           this.year = year;
       }


       public override string ToString()
       {
           return $"{day:D2}/{month:D2}/{year}";
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           Date d1 = new Date(2,5,2008);
           d1.setDate(8,4,2020);
           Console.WriteLine(d1.ToString());
       }
   }
}
