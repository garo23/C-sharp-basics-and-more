using System;

public class Class1
{
    // Write a function that takes a string of parentheses,
    // and determines if the order of the parentheses is valid.
    // The function should return
    // true if the string is valid,
    // and false if it's invalid.
    //Examples
    //"()"              =>  true
   //")(()))"          =>  false
   //"("               =>  false
    //"(())((()())())"  =>  true
    public static bool ValidParentheses(string input)
    {
        
        Stack left = new Stack();
        foreach (char c in input.ToCharArray())
        {
            if (c == '(')
            {
                left.Push(c);
            }
            else if (c == '(' && left.Count != 0 && (char)left.Peek() == '(')
            {
                left.Pop();
            }
            else
            {
                return false;
            }

        }
        return true;
    }
}
}
