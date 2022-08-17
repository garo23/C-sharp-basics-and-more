using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class MallardDuck : IFlyBehavior, IQuackBehavior
    {
        public MallardDuck Mduck;

        public string Quack()
        {
            return "Quack";
        }

        public string Fly()
        {
            return "Flap";
        }
    }
}
