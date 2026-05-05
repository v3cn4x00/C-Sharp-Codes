using System;
using System.Dynamic;
namespace Program
{
   class Account
   {
       private string id;
       private string name;
       private int balance = 0;
      
       public Account(string id, string name)
       {
           this.id = id;
           this.name = name;
       }


       public Account(string id, string name, int balance)
       {
           this.id = id;
           this.name = name;
           this.balance = balance;
       }


       public string getId()
       {
           return id;
       }


       public string getName()
       {
           return name;
       }


       public int getBalance()
       {
           return balance;
       }


       public int credit(int amount)
       {
           balance += amount;
           return balance;
       }


       public int debit(int amount)
       {
           if (amount <= balance)
           {
               balance -= amount;
           }
           else
           {
               Console.WriteLine("Amount exceeded balance");
           }
           return balance;
       }


       public int transferTo(Account another, int amount)
       {
           if (amount <= balance)
           {
               another.balance += amount;
           }
           else
           {
               Console.WriteLine("Amount exceeded balance");
           }
           return balance;
       }


       public override string ToString()
       {
           return $"Account[id = {id}, name = {name}, balance = ${balance}]";
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           Account a2 = new Account("A15OD-G88S", "David Bombal", 54000);;
           Console.WriteLine($"Current balance ${a2.getBalance()}");


           Account a1 = new Account("A1546-T55S", "Steve Jobs", 500000);
           Console.WriteLine($"Total amount ${a1.credit(1000)}");
           Console.WriteLine($"Amount left in account ${a1.debit(5600)}");
           Console.WriteLine($"${a1.transferTo(a2, 5000)} transfer successful");
           Console.WriteLine(a1.ToString());


          
           Console.WriteLine(a2.ToString());
       }
   }
}
