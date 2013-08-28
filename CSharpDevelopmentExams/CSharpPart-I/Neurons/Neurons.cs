using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Neurons
{
    class Neurons
    {
        static void Main(string[] args)
        {
            List<BigInteger> myList = new List<BigInteger>();

            while (true)
            {
                BigInteger currNumber = BigInteger.Parse(Console.ReadLine());

                if (currNumber == -1)
                {
                    break;
                }
                else
                {
                    myList.Add(currNumber);
                }
            }

            BigInteger[,] matrix = new BigInteger[myList.Count, 32];

            for (int i = 0; i < myList.Count; i++)
            {
                BigInteger currentNumber = myList[i];

                for (int j = 31; j >= 0; j--)
                {
                    matrix[i, j] = (currentNumber >> j) & 1;
                }
            }

            for (int i = 0; i < myList.Count; i++)
            {
                int startIndex = 0;

                for (int j = 31; j > 0; j--)
                {
                    if (matrix[i, j] == 1 && matrix[i, j - 1] == 0)
                    {
                        startIndex = j;
                        matrix[i, startIndex] = 2;
                        for (int k = startIndex; k > 0; k--)
                        {
                            if (matrix[i, k] == 0 && matrix[i, k - 1] == 1)
                            {
                                matrix[i, k - 1] = 3;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < myList.Count; i++)
            {
                int start = -1;
                int end = -1;
                for (int j = 31; j > 0; j--)
                {
                    if (matrix[i, j] == 2)
                    {
                        start = j;

                    }
                    if (matrix[i, j] == 3)
                    {
                        end = j;
                    }

                    if (start >= 0 && end >= 0)
                    {
                        for (int y = end + 1; y < start; y++)
                        {
                            matrix[i, y] = 5;
                        }
                    }
                }
            }

            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = 31; j > 0; j--)
                {
                    if (matrix[i, j] == 1 || matrix[i, j] == 2 || matrix[i, j] == 3)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (matrix[i, j] == 5)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    result.Append(matrix[i, j]);
                }

                int resul = BinToDec(result.ToString());

                if (resul >= 0)
                {
                    Console.WriteLine(resul);
                }
                
                result.Clear();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static int BinToDec(string binary)
        {
            int decNum = 0;

            for (int i = binary.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if ((int)binary[i] == '1')
                {
                    int posNum = 1 * (int)Math.Pow(2, j);
                    decNum += posNum;
                }
                else
                {
                    int posNum = 0 * (int)Math.Pow(2, i);
                    decNum += posNum;
                }
            }

            return decNum;
        }
    }
}
