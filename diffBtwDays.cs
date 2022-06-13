using System;

public class Class1
{
	public Class1(int year,int month, int day,int year2, int month2, int day2)
	{
		DateTime start = new DateTime(year, month, day);
		DateTime end = new DateTime(year2, month2, day2);
		TimeSpan difference = end - start;
		return (long)difference.Days;
	}
}
