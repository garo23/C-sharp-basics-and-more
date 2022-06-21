using System;

public class mf{
    public static int mostfrequent(int n)
    {
        int[] arr = new int[n];
        Array.Sort(arr);
        int count = 0;
        int max_count = 1;
           int res = arr[0];

        for (int i =0; i<n; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                count++;
            }
            else count = 1;

            if (count > max_count)
            {
                max_count = count;
                res = arr[i - 1];
            }
        }
        return res;
    }


}