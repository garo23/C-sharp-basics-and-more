using System.Text;
class Exercise1
{
    public static void OddReader()
    {
        StreamReader reader = new StreamReader(@"../sample.txt", Encoding.UTF8);

        using (reader)
        {
            int lineNumber = 0;

            string line = reader.ReadLine();

            while(line != null)
            {
                lineNumber++;
                if(lineNumber % 2 != 0) 
                Console.WriteLine("Line {0}: {1}" ,lineNumber,line);
                line = reader.ReadLine();
            }

        }

    }
}