using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
class Exercise3
{
    public static void LineNumber()
    {

        try
        {
            StreamReader reader = new StreamReader("text2.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("An error has occured" + e.Message);
        }

    }

}