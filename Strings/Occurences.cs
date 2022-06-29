public class Occurences
{
    public static int counter(string substring,string text)
    { 
        string word = string.Empty;
        int substringcounter = 0;

        for(int i = 0; i < text.Length; i++)
        {
            word += text[i];
            if(word.Length == substring.Length)
            {
                if(word.ToLower() == substring.ToLower())
                {
                    substringcounter++;
                }
                word = String.Empty;
                word += text[i];

            }
        }  
        return substringcounter;    

    }
    
    
    

    
}