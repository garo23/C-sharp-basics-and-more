using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class RocketDuck5000 : IQuackBehavior, IFlyBehavior
    {
        public RocketDuck5000 RockDuck;

        public string Quack()
        {
            return "Greetings human";
        }

        public string Fly()
        {
            return "Rocket boosters activated";
        }
    }
}
