//

public class Exercise11
{
    public static string ForbiddenWords(string text)
    {
        string[] forbidenWords = Console.ReadLine().Split(','); //array of words
        
        for(int i = 0; i < forbidenWords.Length; i++)
        {
            int existForbidenWord = 0;
            if ((existForbidenWord = text.IndexOf(forbidenWords[i])) >= 0) //checks if forbiden word exists
            {
                string replaced = new string('*', forbidenWords[i].Length); 
                //replaces the length of the word with'*' same length
                text = text.Replace(forbidenWords[i], replaced);

            }

        }
        return text;
    }
}