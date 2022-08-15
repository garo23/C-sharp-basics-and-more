using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAnimals
{
    public class Pigeon : Animals
    {
        public Pigeon() { }
        public override void GetSound()
        {
            Console.WriteLine("Guurrr");
            
        }
    }
}
