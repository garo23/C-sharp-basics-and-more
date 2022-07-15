using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
class Exercise4
{
    public static void Matrix()
    {
      
        var reader = new StreamReader(@"Matrix.txt" ,Encoding.UTF8);
        string size = reader.ReadLine();
        int result = Int32.Parse(size);
        int[,] matrix = new int[result, result];

        string row1 = reader.ReadLine();
        string row2 = reader.ReadLine();
        string row3 = reader.ReadLine();
        string row4 = reader.ReadLine();

        string[] firstrow = row1.Split(' ');
        string[] secondrow = row2.Split(' ');
        string[] thirdrow = row3.Split(' ');
        string[] forthhrow = row4.Split(' ');

    }

}