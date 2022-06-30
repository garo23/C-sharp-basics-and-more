using System;
class Palindrome21
{
     public static bool IsPalindrome(string word)
    {
        string[]arr = word.Split(' ');  
        for(int i = 0; i < word.Length/2; i++)
        {
            if (arr[i].ToLower() == arr[arr.Length - 1 - i].ToLower())
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }


}