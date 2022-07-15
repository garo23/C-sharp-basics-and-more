using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
class Exercise4
{
    public static double[,] matrix { get; private set; }

    public static void Matrix()
    {
        string matrixInput = @"../../../MyFiles/MatrixInput.txt";
        string matrixOutput = @"../../../MyFiles/MatrixOutput.txt";
        double[,] matrix;
        double result;
        try
        {
            matrix = ReadToArray(matrixInput);
            result = MaxArea(matrix);
            ExportIntoOutputFile(matrixOutput, result);


        }
        catch (Exception ex)
        {
            if (ex is NullReferenceException) Console.WriteLine("The matrix is not correctly filled due to an error.");
            else throw;
        }
    }

    private static double[,] ReadToArray(string matrixInput)
    {
        try
        {
            
            StreamReader reader = new StreamReader(matrixInput, Encoding.UTF8);

            using (reader)
            {
                 int sizeOfMatrix = int.Parse(reader.ReadLine());
                double [,] matrix = new double[sizeOfMatrix,sizeOfMatrix];
                 int row = 0;
                 int col = 0;
                 string line = reader.ReadLine();

                 while(line != null) {
                     string[] lineArr = line.Split();
                    
                     foreach (string str in lineArr)
                     {
                         Console.Write("{0} ", str);
                         matrix[row,col] = Double.Parse(str);
                         col++;
                     }
                     line = reader.ReadLine();
                     Console.WriteLine();
                     row++;
                 }
            }
            return matrix;
        }
        
        catch (Exception ex)
        {
            Console.WriteLine("The matrix cannot be returned correctly: " + ex.Message);
            return null;
        }
        

    }

    static double MaxArea(double[,] matrix)
    {
        double max = 0;
        double temp = 0;
        try
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    temp = matrix[row,col] + matrix[row,col + 1] + matrix[row + 1,col] + matrix[row + 1,col + 1];
                    if (temp > max) max = temp;
                }
            }
        }
        catch (Exception ex)
        {
            if (ex is IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range: " + ex.Message);
            }
            else throw;
        }
        return max;
    }

    static void ExportIntoOutputFile<T>(string path, T result)
    {
        StreamWriter writer;
        try
        {
            writer = new StreamWriter(@"OutputMatrix.txt", false, Encoding.UTF8);
            using (writer)
            {
                writer.WriteLine(result);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error has occured: " + ex.Message);

        }

    }
}