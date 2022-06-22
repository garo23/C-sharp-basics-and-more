//Write a program, which creates an array containing all Latin letters.
//The user inputs a word from the console
//and as result the program prints to the console the indices of the letters from the word.
//
class word
{
    public void indexofletter()
    {
        char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        Console.Write("Enter a word: ");
        string sentence = (Console.ReadLine());
        char[] word = sentence.ToCharArray();

        for (int i = 0; i < word.Length; i++)
            for (int j = 0; j < alphabet.Length; j++)
                if (word[i] == alphabet[j]) Console.Write("{0} ", j);

    } 


}