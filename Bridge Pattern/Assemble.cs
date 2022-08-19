using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Vehicle
{
    public class Assemble : IWorkshop
    {
        public void Work()
        {
            Console.WriteLine("Assembled");
        }
        
    }
}
