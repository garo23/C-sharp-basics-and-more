using System.Text;
class Exercise7
{
    public static void SF()
    {
        string line = String.Empty;
        string inputFile = @"../../../MyFiles/7input.txt";
        string outputFile = @"../../../MyFiles/7Output.txt";
        var reader = new StreamReader(inputFile, Encoding.UTF8);
        var writer = new StreamWriter(outputFile, true, Encoding.UTF8);
        using (reader)
        {
            using (writer)
            {
                line = reader.ReadLine().ToLower();

                while (line != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                    line = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("The substring was successfully replaced.");
    }
}
