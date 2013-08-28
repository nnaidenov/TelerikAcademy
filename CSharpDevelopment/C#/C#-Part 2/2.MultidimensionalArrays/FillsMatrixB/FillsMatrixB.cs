using System;

class FillsMatrixB
{
    static void Main()
    {
        int n = 6;
        int[,] matrix = new int[n, n];

        // Fill Matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int check = (col + 1) % 2;
                if (check != 0)
                {
                    matrix[row, col] = 1 + row + col * n;
                }
                else
                {
                    matrix[row, col] = 2*n-row + (col-1)*n;
                }
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