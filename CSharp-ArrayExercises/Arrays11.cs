// Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S.
// Example: {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}.
class Arrays11
{
    public void Ex9()
    {
        int sum = 0, tempSum;

        Console.Write("Enter array length: ");
        int length = Int32.Parse(Console.ReadLine());

        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter {0} element: ", i);
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length - 1; i++)
        {
            tempSum = arr[i];

            for (int j = i + 1; j < length; j++)
            {
                tempSum += arr[j];
                if (tempSum > sum) sum = tempSum;
            }
        }

        Console.WriteLine("Result is {0}. ", sum);


    }
}