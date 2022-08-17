using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IPaymentStrategy
    {
        abstract void CollectPaymentDetails();
        abstract bool ValidatePaymentDetails();
        abstract void Pay(int amount);
    }
}
