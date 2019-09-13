using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Rectangle : Shape
    {

        public Rectangle(int height, int width):base(height, width)
        {



        }


        public double Area()
        {
            return width * height;
        }
        
        public double Circumference()
        {
            return 2 * (width + height);
        }

    }
}
