using System;
using System.IO;

namespace MaxSumMatrixFromTextFile
{
    class MaxSumMatrixFromTextFile
    {
        static void Main()
        {
            string path = @"../../matrix.txt";
            StreamReader readMatrix = new StreamReader(path);

            int[,] matrix = ReadMatric(readMatrix);
            PrintMatrix(matrix);
            int maxArea = FindMaxArea(matrix);
            WriteInFile(maxArea);
        }

        private static int[,] ReadMatric(StreamReader readMatrix)
        {
            using (readMatrix)
            {
                int size = int.Parse(readMatrix.ReadLine());
                string lines = "";
                int[,] matrix = new int[size, size];
                string[] digits = new string[size];

                for (int i = 0; i < size; i++)
                {
                    lines = readMatrix.ReadLine();
                    digits = lines.Split(' ');

                    for (int row = i; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = int.Parse(digits[col]);
                        }
                    }
                }
                return matrix;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int FindMaxArea(int[,] matrix)
        {
            int sum = 0;
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }
            return maxSum;
        }

        private static void WriteInFile(int maxArea)
        {
            string path = @"../../answer.txt";
            StreamWriter writer = new StreamWriter(path);

            using (writer)
            {
                writer.WriteLine(maxArea);
                writer.Flush();
            }
        }
    }
}