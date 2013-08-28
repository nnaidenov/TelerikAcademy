using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMatrix
{
    public class Matrix<T>
    {
        //Fields
        private int rows;
        private int cols;
        private T[,] matrix;
        //END FIELDS

        //Constructors
        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }
        //END CONSTRUCTORS

        //Properties
        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value > 0 && value <= int.MaxValue)
                {
                    this.rows = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Out Of Range!");
                }
            }
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value > 0 && value <= int.MaxValue)
                {
                    this.cols = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Argument Out Of Range Exception!");
                }
            }
        }
        //END PROPERTIES

        //Indexer
        public T this[int row, int col]
        {
            get
            {
                if (row <= this.rows && col <= this.cols)
                {
                    return matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index Out Of Range Exception!");
                }
            }
            set
            {
                if (row <= this.rows && col <= this.cols)
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index Out Of Range Exception!");
                }
            }
        }
        //END INDEXER

        //Implement the operators
        //+
        public static Matrix<T> operator +(Matrix<T> fMatrix, Matrix<T> sMatrix)
        {
            int fMatrixRows = fMatrix.rows;
            int fMatrixCols = fMatrix.cols;
            int sMatrixRows = sMatrix.rows;
            int sMatrixCols = sMatrix.cols;
            
            Matrix<T> sumMatrix = new Matrix<T>(fMatrixRows, fMatrixCols);

            if (fMatrixCols == sMatrixCols && fMatrixRows == sMatrixRows)
            {
                for (int i = 0; i < fMatrixRows; i++)
                {
                    for (int j = 0; j < fMatrixCols; j++)
                    {
                        sumMatrix[i, j] = (dynamic)fMatrix[i, j] + (dynamic)sMatrix[i, j];
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return sumMatrix;
        }
        //END +

        //-
        public static Matrix<T> operator -(Matrix<T> fMatrix, Matrix<T> sMatrix)
        {
            int fMatrixRows = fMatrix.rows;
            int fMatrixCols = fMatrix.cols;
            int sMatrixRows = sMatrix.rows;
            int sMatrixCols = sMatrix.cols;

            Matrix<T> sumMatrix = new Matrix<T>(fMatrixRows, fMatrixCols);

            if (fMatrixCols == sMatrixCols && fMatrixRows == sMatrixRows)
            {
                for (int i = 0; i < fMatrixRows; i++)
                {
                    for (int j = 0; j < fMatrixCols; j++)
                    {
                        sumMatrix[i, j] = (dynamic)fMatrix[i, j] - (dynamic)sMatrix[i, j];
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }
            return sumMatrix;
        }
        //END -

        //*
        public static Matrix<T> operator *(Matrix<T> fMatrix, Matrix<T> sMatrix)
        {
            int fMatrixRows = fMatrix.rows;
            int fMatrixCols = fMatrix.cols;
            int sMatrixRows = sMatrix.rows;
            int sMatrixCols = sMatrix.cols;

            if (fMatrixCols == sMatrixRows && (fMatrixRows > 0 && sMatrixCols > 0 && fMatrixCols > 0))
            {
                Matrix<T> result = new Matrix<T>(fMatrixRows, sMatrixCols);

                for (int i = 0; i < fMatrixRows; i++)
                {
                    for (int j = 0; j < sMatrixCols; j++)
                    {
                        dynamic sum = 0;
                        for (int k = 0; k < sMatrixCols+1; k++)
                        {
                            sum += (dynamic)fMatrix[i, k] * (dynamic)sMatrix[k, j];
                        }
                        result.matrix[i, j] = sum;
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        //END *

        //True
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i,j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //END TRUE

        //False
        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        //END FALSE
        //IMPLEMENT THE OPERATORS 
    }
}