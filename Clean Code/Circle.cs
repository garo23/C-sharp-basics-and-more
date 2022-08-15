using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeShapes
{
    public class Circle : Shape
    {
        double radius;

        public Circle() { }
        public override double CalculateSurface()
        {
            double result = 0.0;
            result = Math.PI * Math.Pow(radius,2);
            return result;
        }
    }
}
