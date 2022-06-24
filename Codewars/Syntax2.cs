// See https://aka.ms/new-console-template for more information

Console.WriteLine("This program calculates " +
    "the area of a rectangle of triangle");
Console.WriteLine("Enter a and b(for rectangle)" +
    "or a and h (for triangle): ");
    
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 1 for rectangle or" +
    "2 for triangle");

int choice = int.Parse(Console.ReadLine());
double area = (double)(a * b) / choice;
Console.WriteLine("The area of your figure is" + area);





    
    

