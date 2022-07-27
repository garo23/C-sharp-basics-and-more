using System.Text;

public static void Main(){

string input = "Some Text To Try The Substring Extension Method";
int startIndex = int.Parse(Console.ReadLine());
int finalIndex = int.Parse(Console.ReadLine());

StringBuilder finalinput = new StringBuilder(input);
Console.WriteLine(finalinput.JustTheMethod(startIndex,finalIndex)); 

}

public static partial class Exercise1 {
    
    public static string JustTheMethod( this StringBuilder sb , int startindex, int finalindex) {


        return sb.ToString(startindex, finalindex-startindex);

    }

}

