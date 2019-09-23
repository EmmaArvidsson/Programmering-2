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

        public override int Area()
        {
            return  width * height / 2;
        }

        public override int Circumference()
        {
            int hypotenusa = (int)Math.Sqrt(width * width + height * height);
            return hypotenusa + width + height;
        }

    }
}
