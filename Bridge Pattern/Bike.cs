using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Vehicle
{
    public class Bike : Veichle
    {
        public Bike(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2)
        {
        }

        public override void Manufacture()
        {
            Console.WriteLine("Bike");
            workshop1.Work();
            workshop2.Work();
        }
    }
}
