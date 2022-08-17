using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class PaymentService
    {
        private int Cost { get; set; }
        private bool IncludeDelivery;

        private IPaymentStrategy strategy;

        public void ProcessOrder()
        {
            strategy.CollectPaymentDetails();
            if (strategy.ValidatePaymentDetails())
            {
                strategy.Pay(Cost);
            }
        }
    }
}
