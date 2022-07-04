using System.Text;
class Exercise24
{
    public static void SingleLetter(string input)
    {
        StringBuilder sb = new StringBuilder(input);

        for(int i = 1; i<sb.Length; i++)
        {
            for(int j = 0; j < sb.Length; j++)
            {
                if (sb[i] != sb[j])
                {
                    sb.Append(sb[j]);
                }
            }

        }
        Console.WriteLine(sb.ToString());
    }


}