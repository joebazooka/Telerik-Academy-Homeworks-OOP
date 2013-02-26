using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Matrix<T>
        where T: struct, IComparable, IConvertible, IFormattable, IComparable<T>, IEquatable<T>
    {
        // Fields
        private T[,] matrix;
        private int numRows;
        private int numCols;

        // Constructor
        public Matrix(int numRows, int numCols)
        {
            this.matrix = new T[numRows, numCols];
            this.numRows = numRows;
            this.numCols = numCols;
        }

        public Matrix(T[,] value)
        {
                if (value == null || value.GetLength(0) == 0 || value.GetLength(1) == 0)
            {
                throw new ArgumentException();
            }

            this.numRows = value.GetLength(0);
            this.numCols = value.GetLength(1);
            matrix = (T[,])value.Clone();
        }

        // Indexer
        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < this.matrix.GetLength(0)
                    && col >= 0 && col < this.matrix.GetLength(1))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
            }

            set
            {
                if (row < 0 && row >= this.matrix.GetLength(0)
                    && col < 0 && col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }
                this.matrix[row, col] = value;
            }
        }

        // Properties
        public int NumRows
        {
            get
            {
                return this.numRows;
            }
        }

        public int NumCols
        {
            get
            {
                return this.numCols;
            }
        }

        // Operators
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.NumRows == secondMatrix.NumRows && firstMatrix.NumCols == secondMatrix.NumCols)
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.NumRows, firstMatrix.NumCols);

                for (int i = 0; i < firstMatrix.NumRows; i++)
                {
                    for (int j = 0; j < firstMatrix.NumCols; j++)
                    {
                        result[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                    }
                }

                return result;
            }
            else
            {
                throw new ArithmeticException("Matrices are not with the same size.");
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.NumRows == secondMatrix.NumRows && firstMatrix.NumCols == secondMatrix.NumCols)
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.NumRows, firstMatrix.NumCols);

                for (int i = 0; i < firstMatrix.NumRows; i++)
                {
                    for (int j = 0; j < firstMatrix.NumCols; j++)
                    {
                        result[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                    }
                }

                return result;
            }
            else
            {
                throw new ArithmeticException("Matrices are not with the same size.");
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.NumRows == secondMatrix.NumCols)
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.NumRows, secondMatrix.NumCols);

                for (int i = 0; i < firstMatrix.NumRows; i++)
                {
                    for (int j = 0; j < secondMatrix.NumCols; j++)
                    {
                        for (int k = 0; k < firstMatrix.NumCols; k++)
                        {
                            result[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new ArithmeticException("Matrices can not be multiplied.");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            if (matrix == null || matrix.NumCols == 0 || matrix.NumRows == 0)
            {
                return false;
            }

            for (int i = 0; i < matrix.NumRows; i++)
            {
                for (int j = 0; j < matrix.NumCols; j++)
                {
                    if (matrix[i,j].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            if (matrix == null || matrix.NumCols == 0 || matrix.NumRows == 0)
            {
                return true;
            }

            for (int i = 0; i < matrix.NumRows; i++)
            {
                for (int j = 0; j < matrix.NumCols; j++)
                {
                    if (matrix[i, j].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
