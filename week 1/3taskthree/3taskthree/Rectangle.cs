using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3taskthree
{
    class Rectangle
    {
        public int width;
        public int height;
        public int area;
        public int perimeter;
        public Rectangle()
        {
            width = 1;
            height = 1;
            FindArea();
            FindPerimeter();
        }
        public Rectangle(int a, int b)
        {
            width = a;
            height = b;
            FindArea();
            FindPerimeter();
        }
        public Rectangle (int a)
        {
            width = a;
            height = a;
            FindArea();
            FindPerimeter();
        }
        public void FindArea()
        {
            area = width * height;
        }
        public void FindPerimeter()
        {
            perimeter = 2 * (width + height);
        }
        public override string ToString()
        {
            return area + " " + perimeter;
        }
    }
}
