using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class RubberDuck : IQuackBehavior, IFlyBehavior
    {
        public RubberDuck RDuck;

        public string Quack()
        {
            return "Squeak";
        }

        public string Fly()
        {
            return null;
        }
    }
}
