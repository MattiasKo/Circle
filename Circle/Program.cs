//Mattias Kokkonen SUT21
using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
         Circle radie = new Circle(5);
         Console.WriteLine("Arean är "+ radie.getArea());
         radie = new Circle(6);
         Console.WriteLine("Arean är " + radie.getArea());

         Triangle Tri = new Triangle();
         Tri.Hieght = 7;
         Tri.Width = 12;
         Tri.getTriArea();
         Tri.FasTritArea(34, 3);
         

        }
    }
}
