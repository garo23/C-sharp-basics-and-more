public class Sqrt
{
    public static double SQRT(double value)
    {
        if (value < 0)
        {
            throw new System.ArgumentOutOfRangeException("value","Sqrt for negative numbers is undefined");
        }
        return Math.Sqrt(value);
    }

}