using System;
using System.Collections;

class ArrayCount
{
    public void ArrCount()
    {
        int[]arr = new int[20];
        for(int i = 0; i < 20; i++)
        {
            arr[i] = i * 5;

        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
