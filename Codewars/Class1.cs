using System;

public class Class1
{
	public static String phone(string strng, string num)
	{
		string found = 0;
		int count = 0;
		foreach (string entry in string.Split("\n"))
			if (entry.contains("+" num))
            {
				found = entry;
				count++;
            }
		if (count == 0) return "Error =>"
        

        
	}
}
