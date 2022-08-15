using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAnimals
{
    public class Cat : Animals
    {
        public Cat() { }
        public override void GetSound()
        {
            Console.WriteLine("Meow,Meow");
            
        }
    }
}
