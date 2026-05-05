using System;
namespace Program
{
   class Account
   {
       protected internal double account_balance;
       public Account(double account_balance)
       {
           this.account_balance = account_balance;
       }
      
       public virtual void credit(double amount)
       {
           account_balance += amount;
           Console.WriteLine($"${amount} credited. New Balance: ${account_balance}");
       }


       public virtual void debit(double amount)
       {
           if (amount > account_balance)
           {
               Console.WriteLine("Debit amount exceeded account balance.");
           }
           else
           {
               account_balance -= amount;
               Console.WriteLine($"${amount} debited. New Balance: ${account_balance}");
           }
       }
       public double getBalance()
       {
           return account_balance;
       }
   }


   class SavingAccount : Account
   {
       public double interest_rate;
       public SavingAccount(double account_balance, double interest_rate) : base(account_balance)
       {
           this.interest_rate = interest_rate;
       }
       public double calculateInterest()
       {
           return account_balance * (interest_rate / 100);
       }
   }


   class CheckingAccount : Account
   {
       public double fee;
       public CheckingAccount(double account_balance, double fee) : base(account_balance)
       {
           this.fee = fee;
       }
       public override void credit(double amount)
       {
           base.credit(amount);
           account_balance -= fee;
           Console.WriteLine($"Transaction fee of ${fee} charged. New Balance: ${account_balance}");
       }
       public override void debit(double amount)
       {
           if (amount > account_balance)
           {
               Console.WriteLine("Debit amount exceeded account balance. No fee charged.");
           }
           else
           {
               base.debit(amount);
               account_balance -= fee;
               Console.WriteLine($"Transaction fee of ${fee} charged. New Balance: ${account_balance}");
           }
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           SavingAccount s1 = new SavingAccount(50000, 20);
           CheckingAccount c1 = new CheckingAccount(50000, 50);


           Console.WriteLine($"Total Interest: {s1.calculateInterest()}");
           c1.credit(5200);
           c1.debit(1000);


       }
   }
}
