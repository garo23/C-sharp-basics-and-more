using System;
using System.Globalization;

class Exercise7
{

    public static void UpperCase(){
    string text = "this iS a Sample sentence";

    // Creates a TextInfo based on the "en-US" culture.
    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

    // Changes a string to titlecase.
    Console.WriteLine("\"{0}\" to titlecase: {1}", 
                  text, 
                  textInfo.ToTitleCase(text )); 

  }
}