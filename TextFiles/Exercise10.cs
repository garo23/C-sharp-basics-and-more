using System.Text;
class Exercise10
{
    public static void XmlNoTags()
    {
        string inputFile = @"../../../MyFiles/10Input.txt";
        string outputFile = @"../../../MyFiles/10Output.txt";
        StreamReader reader;
        StreamWriter writer;
        bool tagged = true;
       
      
            reader = new StreamReader(inputFile);
            using (reader)
            {
                writer = new StreamWriter(outputFile, false);
                using (writer)
                {
                    StringBuilder sb = new StringBuilder();
                    for (string line; (line = reader.ReadLine()) != null;)
                    {
                        string last = String.Empty;
                        foreach (var item in line.ToList())
                        {
                            if (item.ToString() == "<")
                            {
                                if (tagged == false && last != ">") sb.AppendLine();
                                tagged = true;
                                last = item.ToString();
                                continue;
                            }
                            if (item.ToString() == ">")
                            {
                                tagged = false;
                                last = item.ToString();
                                continue;
                            }
                            if (tagged == false)
                            {
                                sb.Append(item);
                            }
                            last = item.ToString();
                        }
                    }
                    writer.WriteLine(sb.ToString());
                }

            }
            Console.WriteLine("Die Dateien wurden erfolgreich extrachiert !");

        
        }
}

       
    
