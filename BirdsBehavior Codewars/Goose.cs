using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class Goose : IFlyBehavior, IQuackBehavior
    {
        public Goose gg;

        public string Quack()
        {
            return "Honk";
        }

        public string Fly()
        {
            return "Flap";
        }
    }
}
