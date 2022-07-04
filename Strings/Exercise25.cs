class Exercise25
{
    public static void Commas(string input)
    {
        string[] arr = input.Split(',');

        List<string> list = new List<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            list.Add(arr[i]);
        }
        list.Sort();
    }
    
}