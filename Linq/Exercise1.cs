using System.Text;
public static partial class Exercise1 {
    
    public static string JustTheMethod( this StringBuilder sb , int startindex, int finalindex) {


        return sb.ToString(startindex, finalindex-startindex);

    }

}

