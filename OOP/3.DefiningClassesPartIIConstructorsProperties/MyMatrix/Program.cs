using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> myMatrix = new Matrix<int>(4, 3);
            Matrix<int> myMatrix2 = new Matrix<int>(3, 2);

            myMatrix[0, 0] = 1;
            myMatrix[0, 1] = -1;
            myMatrix[0, 2] = 0;
            myMatrix[1, 0] = 0;
            myMatrix[1, 1] = 2;
            myMatrix[1, 2] = 3;
            myMatrix[2, 0] = 1;
            myMatrix[2, 1] = -3;
            myMatrix[2, 2] = 1;
            myMatrix[3, 0] = 4;
            myMatrix[3, 1] = 0;
            myMatrix[3, 2] = 2;

            myMatrix2[0, 0] = 2;
            myMatrix2[0, 1] = 1;
            myMatrix2[1, 0] = -1;
            myMatrix2[1, 1] = 0;
            myMatrix2[2, 0] = 3;
            myMatrix2[2, 1] = 1;

            for (int row = 0; row < myMatrix.Rows; row++)
            {
                for (int col = 0; col < myMatrix.Cols; col++)
                {
                    Console.Write("{0} ", myMatrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int row = 0; row < myMatrix2.Rows; row++)
            {
                for (int col = 0; col < myMatrix2.Cols; col++)
                {
                    Console.Write("{0} ", myMatrix2[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Matrix<int> newMat = new Matrix<int>(myMatrix.Rows, myMatrix2.Cols);
            newMat = myMatrix * myMatrix2;
            for (int row = 0; row < newMat.Rows; row++)
            {
                for (int col = 0; col < newMat.Cols; col++)
                {
                    Console.Write("{0} ", newMat[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            if (newMat)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}