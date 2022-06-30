using System.Text.RegularExpressions;

class Exercise19
{
    public static bool TestEmailRegex(string emailAdress)
    {
        string patternStrict = "^([a - zA - Z0 - 9_.] +)@([a - zA - Z0 - 9_] +)([a-zA-Z]{2,5})$";

        Regex reStrict = new Regex(patternStrict);
        bool isStrictMatch = reStrict.IsMatch(emailAdress);

        return isStrictMatch;

    }
}

