using System;
using System.Text;
public class StringReverse
{

    public static string ReverseString(string str)
    {
        StringBuilder sb = new StringBuilder();
        for(int i = str.Length; i>=0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
}