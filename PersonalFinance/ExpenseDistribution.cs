using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class ExpenseDistribution
    {
        public string ExpenseDistributionName { get; set; }
        private List<ExpenseDistributionItem> expenseDistributionItems { get; set; }

        public void AddExpenseTypes(ExpenseDistributionItem item)
        {
            expenseDistributionItems.Add(item);
        }

        public void RemoveExpenseTypes()
        {
            expenseDistributionItems.Clear();
        }

        public bool CheckPercentage(ExpenseDistributionItem exp, Income inc)
        {
            var result = exp.Expense.Amount * inc.Amount / 100;
            return result > exp.Percentage;

        }




        /*public ExpenseDistribution()
        {
           
            ExpenseDistributionItem needs = new ExpenseDistributionItem(50,need);
            ExpenseDistributionItem wants = new ExpenseDistributionItem(30, want);
            ExpenseDistributionItem savings = new ExpenseDistributionItem(20, saving);
            
            expenseDistributionItems.Add(needs);
            expenseDistributionItems.Add(wants);
            expenseDistributionItems.Add(savings);
            */
    }


}




