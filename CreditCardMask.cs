// See https://aka.ms/new-console-template for more information
//"4556364607935616" --> "############5616"
//"64607935616"-- > "#######5616"
//"1"-- > "1"
//""-- > ""
public class Maskify
{
    public static String maskify(String str)
    {
        char[] strChars = str.toCharArray();
        for (int i = 0; i < strChars.length - 4; i++)
        {
            strChars[i] = '#';
        }
        return new String(strChars);
    }
}
