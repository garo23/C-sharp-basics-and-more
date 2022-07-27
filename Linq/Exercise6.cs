class Exercise6
{


    public static void Multiplies()
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            list.Add(num);
        }

        var divisors =
            from l in list
            where l % 3 == 0 && l % 7 == 0
            select l;

        foreach(var item in divisors)
        {
            Console.WriteLine(item + " ");
        }

    }
}