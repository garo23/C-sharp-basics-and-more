// http://www.devbg.org/forum/index.php резултатът е:
//[protocol]= "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

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