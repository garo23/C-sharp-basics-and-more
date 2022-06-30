using System;
using System.Text.RegularExpressions;
class Exercise16
{
    public static void hyperlinks(string text)
    {
        string newtext = Regex.Replace(text, @"<a href=""", "[URL="); //(къде заместваме, кое заместваме, с какво го заместваме)
        newtext = Regex.Replace(newtext, @""">", "] ");
        newtext = Regex.Replace(newtext, "</a>", "[/URL]");

        Console.WriteLine();
        Console.WriteLine(newtext);


    }

}