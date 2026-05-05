using System;
namespace Program
{
   class Product
   {
       public string? name;
       public double price;
       public double discount;
       public Product(string name, double price, double discount)
       {
           this.name = name;
           this.price = price;
           this.discount = discount;
       }
       public virtual void Displayinfo()
       {
           Console.WriteLine($"Name: {name}\nPrice: ${price}\nDiscount: ${price * ( discount / 100)}");
       }
   }


   class Electronics : Product
   {
       public int warrantyperiod;
       public Electronics(string name, double price, double discount, int warrantyperiod) : base(name, price, discount)
       {
           this.warrantyperiod = warrantyperiod;
       }
       public override void Displayinfo()
       {
           base.Displayinfo();
           Console.WriteLine($"Warrany Period: {warrantyperiod} years");
       }
   }


   class Book : Product
   {
       public string? author;
       public string? isbn;
       public Book(string author, string isbn, string name, double price, double discount) : base(name, price, discount)
       {
           this.author = author;
           this.isbn = isbn;
       }
       public override void Displayinfo()
       {
           base.Displayinfo();
           Console.WriteLine($"Author: {author}\nISBN: {isbn}");
       }
   }


   class Clothing : Product
   {
       public char size;
       public string? material;


       public Clothing(char size, string material, string name, double price, double discount) : base(name, price, discount)
       {
           this.size = size;
           this.material = material;
       }
       public override void Displayinfo()
       {
           base.Displayinfo();
           Console.WriteLine($"Size: {size}\nMaterial: {material}");
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           List<Product> products = new List<Product>();
           products.Add(new Electronics("Mobile Phone", 2000, 15, 1));
           products.Add(new Book("David", "978-3-16-148410-0", "Basics of C#", 50, 2));
           products.Add(new Clothing('M', "Silk", "Gucci", 10000, 20));
          
           foreach (Product p in products)
           {
               p.Displayinfo();
               Console.WriteLine("--------------");  
           }
       }
   }
}
