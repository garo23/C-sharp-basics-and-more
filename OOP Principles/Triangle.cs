using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeShapes
{
    public class Triangle : Shape {

        public Triangle() { }   
        public override double CalculateSurface()
        {
            return Length * Width/2;
            
        }
    }
}
