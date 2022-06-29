using System.Text;

class Excercise7
{
    public static void symbols(string input)
    {
        string line;
        line = Console.ReadLine();
        if (line.Length > 20)
        {
            for(int i =0; i<20; i++)
            {
                Console.WriteLine(line[i]);
            }
            Console.WriteLine();

        }
        else
        {
            string newLine = line.PadRight(20, '*'); //имаме общо 20 символа 20=символите от line + толкова '*' до 20 
            Console.WriteLine(newLine); 

        }

    }
}