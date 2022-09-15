using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Income
    {
        public Income(IncomeType incomeType, string incomeName, double amount)
        {
            IncomeType = incomeType;
            IncomeName = incomeName;
            Amount = amount;
        }
        public IncomeType IncomeType { get; set; }
        public string IncomeName { get { return IncomeName; } set { } }
        public double Amount { get; set; }  
    }
}
