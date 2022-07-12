using System.Text;
class Exercise10
{ 
  public static void XmlNoTags()
    {
        var reader = new StreamReader(@"../startfinish.txt", Encoding.UTF8);
        string txt = reader.ReadToEnd();
        int counter = 0;

        StringBuilder sb = new StringBuilder();

        using (reader)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '>') { 
                counter++;
            }
                if (txt[i] == '<')
                {
                    counter--;
                }

                if (counter > 0)
                {
                    sb.Append(txt[i]);  
                }
                
            }
        }

    }


}