//Exsample : We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//Result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

public class Excercise6
{
    public static void UpCase()
    {
        int firstIndex = 0;
        int secondIndex = 0;
        string str = Console.ReadLine();
        while (firstIndex < str.LastIndexOf("</upcase>")) //start index of last occurence of "</upcase>"
        {
            firstIndex = str.IndexOf("</upcase>", firstIndex + 1);
            secondIndex = str.IndexOf("</upcase>", secondIndex + 1);
            string upCase = str.Substring(firstIndex + 8, secondIndex - firstIndex - 8).ToUpper();
            string toReplace = str.Substring(firstIndex,secondIndex - firstIndex + 9);
            str = str.Replace(toReplace, upCase);
        
        }
        Console.WriteLine(str);
    }

}