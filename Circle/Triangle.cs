using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    class Triangle
    {
        public int Width;
        public int Hieght;
    
        public void getTriArea()
        {
            Console.WriteLine("Arean på triangeln är: " + (Width * Hieght) / 2);
        }
        public void FasTritArea (int width, int hieght)
        {
            Console.WriteLine("Arean på triangeln är: "+(width*hieght)/2);
        }
    }
}
