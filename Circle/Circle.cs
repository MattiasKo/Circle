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
         public float getArea()
        {

            float result = _Radius * _Radius * _pi;
            return result;
            
        }
     

        
           
        
    }
}
