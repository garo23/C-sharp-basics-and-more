using PersonalFinance;
using PersonalFinanse;

Console.WriteLine("Welcome!");
Console.WriteLine("Please enter your income");
User User = new User();
Console.WriteLine("Please enter your name: ");
User.Name = Console.ReadLine();
Console.WriteLine("Now enter a secured password: ");
User.Password = Console.ReadLine();

OperationsMenu.MainMenu();

/*while (Console.ReadKey(true).Key != ConsoleKey.Escape)
{

    Console.WriteLine("Enter some expenses: ");
    Expense exp = new Expense();
    Console.WriteLine("Which category is the expense");
    exp.ExpenseType.Name = Console.ReadLine();
    exp.ExpenseName = Console.ReadLine();
    exp.Amount = double.Parse(Console.ReadLine());
    exp.Location = Console.ReadLine();
    
    User.Expenses.Add(exp);

    ExpenseType ext = new ExpenseType();
}*/
