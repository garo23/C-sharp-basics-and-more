using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeShapes
{

    public class Rectangle : Shape
    {     
        public Rectangle() { }
        public override double CalculateSurface()
        {
            return Width * Length;
        }

    }
}
