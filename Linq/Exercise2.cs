using System;
public static partial class Exercise2
{


    public static double Sum<T>(this IEnumerable<Decimal> IEnum)
    {
        var sum = (decimal)0;
        foreach (var item in IEnum)
        {
            sum += item;


        }
        return (double)Convert.ToDecimal(sum);
    }
    public static double Average<T>(this IEnumerable<Decimal> IEnum)
    {
        var avg = (decimal)0;  
         var sum = (decimal)0;
        int count = 0;
        foreach(var item in IEnum)
        {
            sum += item;
            count++;
        }
        avg = sum/count;
        return (double)Convert.ToDecimal(avg);
    }

    static T Min <T>(this IEnumerable<T> IEnum)
    {
        dynamic min = IEnum.First<T>();
        foreach (var item in IEnum)
        {
           if (item < min)
            {
                min = item;  
            }
        }
        return min;
    }
}

    

