using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Triangle : Shape
    {

        public Triangle(int height, int width):base(height, width)
        {

        }

        public double Area()
        {
            return  width * height / 2;
        }

        public double Circumference()
        {
            double hypotenusa = Math.Sqrt(width * width + height * height);
            return hypotenusa + width + height;
        }

    }
}
