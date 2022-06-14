Let us consider this example (array written in general format):

//ls = [0, 1, 3, 6, 10]

//Its following parts:

//ls = [0, 1, 3, 6, 10]
//ls = [1, 3, 6, 10]
//ls = [3, 6, 10]
//ls = [6, 10]
//ls = [10]
//ls = []
//The corresponding sums are (put together in a list): [20, 20, 19, 16, 10, 0]

//The function parts_sums (or its variants in other languages) will take as parameter a list ls and return a list of the sums of its parts as defined above.

//Other Examples:
//ls = [1, 2, 3, 4, 5, 6]
//parts_sums(ls)-> [21, 20, 18, 15, 11, 6, 0]

//ls = [744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358]
//parts_sums(ls)-> [10037855, 9293730, 9292795, 9292388, 9291934,9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0]



public static int[] PartsSums(int[] ls)
{
    int arr = new int[ls.Length + 1];
    int sum = ls.Sum();
    arr[0] = sum;
    for (int i = 1; i < res.Length; i++)
    {
        sum -= ls[i - 1];
        arr[i] = sum;
    }
}
return arr;
}
  