using System.Text;
class Exercise7
{
    public static void SF()
    {
        var reader = new StreamReader(@"../startfinish.txt", Encoding.UTF8);
        using (reader)
        {
            var line = reader.ReadLine();
            line.Replace("start", "finish");
            Console.WriteLine(line);    
            while (!string.IsNullOrWhiteSpace(line)) { 
            line = reader.ReadLine();
            line.Replace("start", "finish");
                Console.WriteLine(line);
            }

        }

    }
}