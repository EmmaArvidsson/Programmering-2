using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Rectangle : IShape
    {
        int width;
        int height;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;

        }

        public int Area()
        {
            return width * height;
        }
        
        public int Circumference()
        {
            return 2 * (width + height);
        }

    }
}
