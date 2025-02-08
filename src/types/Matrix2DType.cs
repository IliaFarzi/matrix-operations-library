using System;
using MatrixOperationsLibrary.Interfaces;

namespace MatrixOperationsLibrary.Types
{
    public class Matrix2DType<T> : IMatrixInterface<T>
    {
        private T[,] _array;

        public int Rows { get; private set; }
        public int Columns { get; private set; }

        public Matrix2DType(int rows, int columns)
        {
            Initialize(rows, columns);
        }

        public void Initialize(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _array = new T[rows, columns];
        }

        public void Set(int row, int col, T value)
        {
            ValidateIndices(row, col);
            _array[row, col] = value;
        }

        public T Get(int row, int col)
        {
            ValidateIndices(row, col);
            return _array[row, col];
        }

        public IMatrixInterface<T> Transpose()
        {
            var transposedMatrix = new Matrix2DType<T>(Columns, Rows);
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    transposedMatrix.Set(j, i, _array[i, j]);
                }
            }
            return transposedMatrix;
        }

        public double Determinant()
        {
            if (typeof(T) != typeof(double))
                throw new InvalidOperationException("Determinant can only be calculated for matrices of type double.");

            if (Rows != Columns)
                throw new InvalidOperationException("Determinant can only be calculated for square matrices.");

            return CalculateDeterminant((double[,])Convert.ChangeType(_array, typeof(double[,]))); 
        }

        private double CalculateDeterminant(double[,] matrix)
        {
            int size = matrix.GetLength(0);

            if (size == 1)
                return matrix[0, 0];

            if (size == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            double determinant = 0;
            for (int col = 0; col < size; col++)
            {
                double[,] subMatrix = CreateSubMatrix(matrix, 0, col);
                determinant += (col % 2 == 0 ? 1 : -1) * matrix[0, col] * CalculateDeterminant(subMatrix);
            }

            return determinant;
        }

        private double[,] CreateSubMatrix(double[,] matrix, int excludingRow, int excludingCol)
        {
            int size = matrix.GetLength(0);
            double[,] result = new double[size - 1, size - 1];
            int rowOffset = 0;

            for (int i = 0; i < size; i++)
            {
                if (i == excludingRow)
                {
                    rowOffset = -1;
                    continue;
                }

                int colOffset = 0;
                for (int j = 0; j < size; j++)
                {
                    if (j == excludingCol)
                    {
                        colOffset = -1;
                        continue;
                    }
                    result[i + rowOffset, j + colOffset] = matrix[i, j];
                }
            }
            return result;
        }

        private void ValidateIndices(int row, int col)
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Columns)
                throw new ArgumentOutOfRangeException("Indices are out of bounds.");
        }
    }
}
