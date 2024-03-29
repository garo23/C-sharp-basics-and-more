﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinance;

namespace PersonalFinanse
{
    public class OperationsMenu
    {
        public static void MainMenu()
        {
            List<Income> incomes = new List<Income>();
            List<Expense> expenses = new List<Expense>();
            bool finished = false;
            do
            {
                menu:
                Console.WriteLine("Main Menu");
                Console.WriteLine("1 - Add an income");
                Console.WriteLine("2 - Add an expense");
                Console.WriteLine("3 - Exit");
                

                switch (Console.ReadLine())
                {
                    case "1":
                        
                        while (incomes.Count >= 0)
                        {
                            Console.Write("\nFirstly, enter your income type: ");
                            IncomeType incomeType = IncomeTypeMenu.MainMenu();
                            Console.Write("Secondly, enter the amount of the income: ");
                            double incomeAmount = double.Parse(Console.ReadLine());


                            Income inc = new Income(incomeType,incomeType.Name, incomeAmount);
                            incomes.Add(inc);
                            double totalAmountOfIncome = 0.00;

                            foreach (Income income in incomes)
                            {
                                totalAmountOfIncome += income.Amount;
                                Console.WriteLine("Income type: {0}, income: {1} lv.", income.IncomeType.Name, income.Amount);
                                Console.WriteLine("Total income amount: {0} lv.", totalAmountOfIncome);
                            }
                            break;
                        }
                        break;
                    case "2":
                        while (expenses.Count >= 0)
                        {
                            Console.Write("\nPlease, enter some expenses:");
                            Console.Write("\nEnter expense name: ");
                            var expenseName = Console.ReadLine();
                            Console.Write("\nWhich category is the expense: ");
                            var expenseType = ExpenseTypeMenu.MainMenu();
                            Console.Write("\nEnter the expense amount: ");
                            double amount = double.Parse(Console.ReadLine());
                            Console.Write("\nEnter the location, where the money were spent: ");
                            var location = Console.ReadLine();


                            Expense exp = new Expense(expenseName, expenseType, amount, DateTime.Now, location);
                            expenses.Add(exp);
                            double totalAmountOfExpenses = 0.00;

                            foreach (var expense in expenses)
                            {
                                totalAmountOfExpenses += expense.Amount;
                                Console.WriteLine("Expense name: {0}, expense type: {1}, amount: {2} lv., date: {3}, location: {4}", expense.ExpenseName,
                                    expense.ExpenseType.Name, expense.Amount, expense.Date, expense.Location);
                                Console.WriteLine("Total expense amount: {0} lv.", totalAmountOfExpenses);
                            }
                            break;
                        }
                        break;
          
                }
                Console.WriteLine("Press i to go to main menu");
                char c = char.Parse(Console.ReadLine());

                if(c=='i')
                {
                    goto menu;
                }
                else
                {
                    finished = true;
                }
                
            } while (!finished);
        }
    }
}
