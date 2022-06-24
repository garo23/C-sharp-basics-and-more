using System;

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
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == '(')
                {
                    count++;
                }
                else if (c == ')')
                {
                    count--;

                    if (count < 0)
                    {
                        return false;
                    }
                }
            }

            return count == 0;
        }
    }