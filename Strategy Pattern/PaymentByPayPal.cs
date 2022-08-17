using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaymentByPayPal : IPaymentStrategy
    {
        private string Email;
        private string Password;    

        public void Pay(int amount)
        {
            Console.WriteLine("Paying " + amount + " using paypal");
        }

        public void CollectPaymentDetails()
        {
            Email = "";
            Password = "";
        }

        public bool ValidatePaymentDetails()
        {
            return false;
        }
    }
}
