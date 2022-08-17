using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class CreditCard
    {
        public string No { get; set; }
        public string CVV { get; set; }
        public string Name { get; set; }

        public int Amount { get; set; }

    public CreditCard(string number, string cvv, string name, int amount)
        {
            No = number;
            CVV = cvv;
            Name = name;
            Amount = amount;
        }
    
    }
}
