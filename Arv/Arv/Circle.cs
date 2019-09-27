using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Circle : IShape
    {
        int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public int Area()
        {
            return (int)(radius * radius * Math.PI);
        }

        public int Circumference()
        {
            return (int)(2 * radius * Math.PI);
        }
    }
}
