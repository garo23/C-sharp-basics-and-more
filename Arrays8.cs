using System;

class maxsubseq{
    public static int maxsum(int n)
    {
        Console.WriteLine("Enter length of array");
        int sum = 0;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int max = array[0];
        for(int i = 1; i < n; i++)
        {
           if(max < array[i])
            {
                max = array[i];

            }
           if(max <= 0)
            {
                return max;
            }
           for(int j = 0; j < n; j++)
            {
                sum += array[j];

            }
            
        }
        return sum;

    }

}