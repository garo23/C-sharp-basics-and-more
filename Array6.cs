class subseq
{
    public  int[]  findLongestConseqSubseq(int a, int[] arr)
    {
        Array.Sort(arr);
        int count = 0; //counts the length of the subsequence
        
        List<int> list = new List<int>();
        for (int i = 0; i < a; i++)
        {
            if (arr[i] != arr[i - 1])
            {

                list.Add(arr[i]);
            }
        }
        for(int i = 0; i<list.Count; i++)
        {
            if (arr[i] == arr[i - 1] + 1)
            {
                list.Add(arr[i]);
                count++;
            }
            else
                count = 1;
        }
        return list.ToArray();


    }
}

