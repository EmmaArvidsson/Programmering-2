﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Triangle : IShape
    {
        int height;
        int width;

        public Triangle(int height, int width)
        {

            this.height = height;
            this.width = width;

        }

        public int Area()
        {
            return  width * height / 2;
        }

        public int Circumference()
        {
            int hypotenusa = (int)Math.Sqrt(width * width + height * height);
            return hypotenusa + width + height;
        }

    }
}
