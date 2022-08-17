using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     public class PaymentByCreditCard : IPaymentStrategy
    {
        private CreditCard card;

        public void Pay(int amount)
        {        
            Console.WriteLine("Paying" + amount + "using creditcard");
            card.Amount = card.Amount - amount;
        }

        public void CollectPaymentDetails()
        {
            card = new CreditCard("CardNumber", "CVV", "CardHolder", 2400);
        }

        public bool ValidatePaymentDetails()
        {
            return false;
        }
    }
}
