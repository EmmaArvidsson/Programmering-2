using System;
using System.Collections.Generic;
using System.Text;



namespace Arv
{
    class Shape
    {
        protected int height;
        protected int width;

        public Shape(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        class Rectangle : Shape
        {
        }
    }
}
