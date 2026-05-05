using System;
namespace Program
{
   class Staff
   {
       public string? code;
       public string? name;


       public Staff(string name, string code)
       {
           this.name = name;
           this.code = code;
       }


       public virtual void Displayinfo()
       {
           Console.WriteLine($"Name: {name} Code: {code}");
       }
   }


   class Typist : Staff
   {
       public int speed;
       public Typist(string name, string code, int speed) : base(name, code)
       {
           this.speed = speed;
       }


       public override void Displayinfo()
       {
           base.Displayinfo();
           Console.WriteLine($"Speed: {speed}");  
       }
   }


   class Teacher : Staff
   {
       public string? subject;
       public string? publication;
       public Teacher(string name, string code, string subject, string publication) : base(name, code)
       {
           this.subject = subject;
           this.publication = publication;
       }
       public override void Displayinfo()
       {
           base.Displayinfo();
           Console.WriteLine($"Subject: {subject}, Publication: {publication}");
       }
   }


   class Officer : Staff
   {
       public int grade;
       public Officer(string name, string code, int grade) : base(name, code)
       {
           this.grade = grade;
       }


       public override void Displayinfo()
       {
           base.Displayinfo();
           Console.WriteLine($"Grade: {grade}");
       }
   }


   class Casual : Typist
   {
       public int wages;
       public Casual(string name, string code, int speed, int wages) : base(name, code, speed)
       {
           this.wages = wages;
       }


       public override void Displayinfo()
       {
           base.Displayinfo();
           Console.WriteLine($"Wages: ${wages}");
       }
   }


   class Regular : Typist
   {
       public Regular(string name, string code, int speed) : base(name, code, speed)
       {
          
       }
       public override void Displayinfo()
       {
           base.Displayinfo();
       }


   }


   class Program
   {
       static void Main(string[] args)
       {
           Teacher t1 = new Teacher("David", "5AA", "Maths", "John d.");
           Officer o1 = new Officer("Roger", "4FA", 5);
           Casual c1 = new Casual("Steve", "7SA", 90, 5000);
           Regular r1 = new Regular("Hopper", "6TB", 50);


           t1.Displayinfo();
           o1.Displayinfo();
           c1.Displayinfo();
           r1.Displayinfo();
       }
   }
}
