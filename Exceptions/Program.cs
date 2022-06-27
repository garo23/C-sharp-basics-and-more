Console.Write("Enter start value:");
int start = int.Parse(Console.ReadLine());
Console.Write("Enter end value:");
int end = int.Parse(Console.ReadLine());

for(int i =0; i<10; i++)
{
    try
    {
        ReadNumber(start, end);
    }catch(InvalidNumberException e)
    {
        Console.WriteLine(e.Message);
    }catch(FormatException e)
    {
        Console.WriteLine(e.Message);
    }
    finally
    {
        Console.WriteLine("Good bye");
    }
}


 void ReadNumber( int start, int end)
{
   
    int num = int.Parse(Console.ReadLine());
    if (num < start || num > end)
    {
        throw new InvalidNumberException(start, end);
    }

}


