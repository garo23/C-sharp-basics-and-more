using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeShapes
{
    public abstract class Shape
    {
        public static double length;
        public static double width;

        public virtual double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                   throw new ArgumentOutOfRangeException("Please enter correct width");
                }
                width = value;
            }
        }

        public virtual double Length
        {
            get { return length; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Please enter correct width");
                }
                { length = value; }
            }
        }
       
        
        public abstract double CalculateSurface();
        
    }
}
