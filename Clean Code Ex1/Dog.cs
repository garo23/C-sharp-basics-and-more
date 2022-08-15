using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAnimals
{
    public class Dog : Animals
    {
        public Dog() { }
        public override void GetSound()
        {
            Console.WriteLine("Woof Woof");
            
        }
    }
}
