using System;

class MainFunc{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        maxsubseq maxsubseq = new maxsubseq();

        Console.WriteLine(maxsubseq.maxsum(a));



    }
}



