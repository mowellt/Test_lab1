using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
    public class Triangle
    {
        public Triangle()
        {

        }

        public Triangle(double a, double b, double c)
        {
            Check(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        public double A;
        public double B;
        public double C;
        

        public void SetSides(double a, double b, double c)
        {
            Check(a, b, c);
            A = a;
            B = b;
            C = c;
        }
        private void Check(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new FormatException();

            if ((a + b) < c || (a + c) < b || (b + c) < a)
                throw new ArgumentException();
        }

        public double Area()
        {
            double perimetr = (A + B + C) / 2.0;
            double area = Math.Sqrt(perimetr * (perimetr - A) * (perimetr - B) * (perimetr - C));
            return area;
        }
    }
}