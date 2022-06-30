class Exercise15
{
    public static void dictionary(string input)  {
         Dictionary<string, string> dict = new Dictionary<string, string>();

        dict.Add(".NET", "platform for applications from Microsoft");
        dict.Add("CLR", "managed execution enviroment for .NET");
        dict.Add("namespace", "hiererchical organisation of classes");

        Console.WriteLine(dict[input]);

      }



}
        