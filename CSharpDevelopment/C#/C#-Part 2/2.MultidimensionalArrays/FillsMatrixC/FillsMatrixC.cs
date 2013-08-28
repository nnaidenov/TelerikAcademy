using System;

class FillsMatrixC
{
    static void Main()
    {
        int n = 4;
        int[,] matrix = new int[n, n];
        int number = 1;

        // Fill Matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[n - row + col - 1, col] = number++;
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, n - col - 1] = number++;
            }
        }

        // Print Matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}