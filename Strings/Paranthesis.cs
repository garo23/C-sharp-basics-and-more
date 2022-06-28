public class Paranthesis
{
    public static bool validParanthesis(String input)
    {
        int countleft = 0;
        int countright = 0;
        char []arr = new char [input.Length];
       arr  = input.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == '(')
            {
                countleft++;
            }else if(arr[i] == ')')
            {
                countright++;
            }
            if (countleft==countright)
            {
                return true;
            }
        }
        return false;

    }

}