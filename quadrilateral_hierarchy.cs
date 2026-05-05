using System;
namespace Program
{
   class Quadrilateral
   {
       private double x1, y1;
       private double x2, y2;
       private double x3, y3;
       private double x4, y4;


       public Quadrilateral(double x1, double y1,
                            double x2, double y2,
                            double x3, double y3,
                            double x4, double y4)
       {
           this.x1 = x1; this.y1 = y1;
           this.x2 = x2; this.y2 = y2;
           this.x3 = x3; this.y3 = y3;
           this.x4 = x4; this.y4 = y4;
       }
       public double X1 { get { return x1; } set { x1 = value; } }
       public double Y1 { get { return y1; } set { y1 = value; } }
       public double X2 { get { return x2; } set { x2 = value; } }
       public double Y2 { get { return y2; } set { y2 = value; } }
       public double X3 { get { return x3; } set { x3 = value; } }
       public double Y3 { get { return y3; } set { y3 = value; } }
       public double X4 { get { return x4; } set { x4 = value; } }
       public double Y4 { get { return y4; } set { y4 = value; } }


       public override string ToString()
       {
           return $"Coordinates: ({x1},{y1}), ({x2},{y2}), ({x3},{y3}), ({x4},{y4})";
       }
   }


   class Trapezoid : Quadrilateral
   {
       private double base1, base2, height;


       public Trapezoid(double base1, double base2, double height,
                        double x1, double y1, double x2, double y2,
                        double x3, double y3, double x4, double y4)
           : base(x1, y1, x2, y2, x3, y3, x4, y4)
       {
           this.base1  = base1;
           this.base2  = base2;
           this.height = height;
       }


       public double Base1  { get { return base1;  } set { base1  = value; } }
       public double Base2  { get { return base2;  } set { base2  = value; } }
       public double Height { get { return height; } set { height = value; } }


       public virtual double Area()
       {
           return 0.5 * (base1 + base2) * height;
       }


       public override string ToString()
       {
           return $"Trapezoid -> Base1: {base1}, Base2: {base2}, Height: {height}\n" + base.ToString();
       }
   }


   class Parallelogram : Trapezoid
   {
       private double pBase, pHeight;


       public Parallelogram(double pBase, double pHeight,
                            double x1, double y1, double x2, double y2,
                            double x3, double y3, double x4, double y4)
           : base(pBase, pBase, pHeight, x1, y1, x2, y2, x3, y3, x4, y4)
       {
           this.pBase   = pBase;
           this.pHeight = pHeight;
       }


       public double PBase   { get { return pBase;   } set { pBase   = value; } }
       public double PHeight { get { return pHeight; } set { pHeight = value; } }


       public override double Area()
       {
           return pBase * pHeight;
       }


       public override string ToString()
       {
           return $"Parallelogram -> Base: {pBase}, Height: {pHeight}\n" + base.ToString();
       }
   }


   class Rectangle : Parallelogram
   {
       private double width, rHeight;


       public Rectangle(double width, double height,
                        double x1, double y1, double x2, double y2,
                        double x3, double y3, double x4, double y4)
           : base(width, height, x1, y1, x2, y2, x3, y3, x4, y4)
       {
           this.width   = width;
           this.rHeight = height;
       }


       public double Width   { get { return width;   } set { width   = value; } }
       public double RHeight { get { return rHeight; } set { rHeight = value; } }


       public override double Area()
       {
           return width * rHeight;
       }


       public override string ToString()
       {
           return $"Rectangle -> Width: {width}, Height: {rHeight}\n" + base.ToString();
       }
   }


   // Level 5
   class Square : Rectangle
   {
       private double side;


       public Square(double side,
                     double x1, double y1, double x2, double y2,
                     double x3, double y3, double x4, double y4)
           : base(side, side, x1, y1, x2, y2, x3, y3, x4, y4)
       {
           this.side = side;
       }


       public double Side { get { return side; } set { side = value; } }


       public override double Area()
       {
           return side * side;
       }


       public override string ToString()
       {
           return $"Square -> Side: {side}\n" + base.ToString();
       }
   }


   class Program
   {
       static void Main(string[] args)
       {
           Trapezoid t = new Trapezoid(10, 6, 4,
                                       0,0, 10,0, 8,4, 2,4);
           Console.WriteLine("===== Trapezoid =====");
           Console.WriteLine(t.ToString());
           Console.WriteLine($"Area: {t.Area()}");


           Console.WriteLine();


           Parallelogram p = new Parallelogram(8, 5,
                                               0,0, 8,0, 10,5, 2,5);
           Console.WriteLine("===== Parallelogram =====");
           Console.WriteLine(p.ToString());
           Console.WriteLine($"Area: {p.Area()}");


           Console.WriteLine();


           Rectangle r = new Rectangle(7, 4,
                                        0,0, 7,0, 7,4, 0,4);
           Console.WriteLine("===== Rectangle =====");
           Console.WriteLine(r.ToString());
           Console.WriteLine($"Area: {r.Area()}");


           Console.WriteLine();


           Square s = new Square(5,
                                  0,0, 5,0, 5,5, 0,5);
           Console.WriteLine("===== Square =====");
           Console.WriteLine(s.ToString());
           Console.WriteLine($"Area: {s.Area()}");
       }
   }
}
