
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12_Solution_6
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\gaprahamyan\Desktop\Arrays\Arrays\Arrayss"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified path is invalid!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Invalid syntax!");
            }
        }
    }
}
