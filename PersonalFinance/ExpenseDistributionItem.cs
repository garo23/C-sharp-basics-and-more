using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class ExpenseDistributionItem
    {
        
        public ExpenseDistributionItem(double percentage, Expense expense)
        {
            Percentage = percentage;
            Expense = expense;
        }
        public double Percentage { get; set; }
        public Expense Expense { get; set; }

    }
}
