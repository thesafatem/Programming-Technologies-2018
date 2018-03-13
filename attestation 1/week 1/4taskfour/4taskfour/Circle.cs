using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4taskfour
{
    class Circle
    {
        public double radius;
        public double circumference;
        public double area;
        public double diameter;
        public Circle()
        {
            radius = 1;
            FindArea();
            FindCircumference();
            FindDiameter();
        }
        public Circle(double a)
        {
            radius = a;
            FindArea();
            FindCircumference();
            FindDiameter();
        }
        public void FindDiameter()
        {
            diameter = 2 * radius;
        }
        public void FindCircumference()
        {
            circumference = 2 * Math.PI * radius;
        }
        public void FindArea()
        {
            area = Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return diameter + " " + circumference + " " + area;
        }
    }
}
