//Например: "C# is not C++ and PHP is not Delphi" -> "Delphi not is PHP and C++ not is C#".

using System.Text;
class Exercise14
{
    public static void stringreverse(string input)
    {
        string[] arr = input.Split(" ");
        StringBuilder sb = new StringBuilder();

        for(int i = arr.Length-1; i>=0; i--)
        {
            sb.Append(arr[i]);


        }
        Console.WriteLine(sb.ToString());

    }



}
