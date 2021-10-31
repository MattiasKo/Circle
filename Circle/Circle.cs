using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    public class Circle
    {
        public float _pi = 3.141f;
        public int _Radius;

        public Circle(int radie)
        {
            _Radius = radie; 
        }
         public void getArea() {
            Console.WriteLine("Arean på cirkeln är "+_Radius * _Radius * _pi);
            
        }
     

        
           
        
    }
}
