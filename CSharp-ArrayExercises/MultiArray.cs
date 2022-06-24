class MultiArray
{
    public void dimension()
    {
        int[,] intMatrix = new int[3, 4];
        float[,] floatMatrix = new float[8, 2];
        string[,,] stringCube = new string[5, 5, 5];
        int[,] matrix =
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
        };
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}