using System;
using MatrixOperationsLibrary.Interfaces;
using MatrixOperationsLibrary.Types;

namespace MatrixOperationsLibrary.Algorithms
{
    public class ScalarOperationsAlgorithm : IMatrixScalarOperationsAlgorithm<double>
    {
        public IMatrixInterface<double> Multiply(IMatrixInterface<double> matrix, double scalar)
        {
            var result = new Matrix2DType<double>(matrix.Rows, matrix.Columns);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    result.Set(i, j, matrix.Get(i, j) * scalar);
                }
            }
            return result;
        }

        public IMatrixInterface<double> Add(IMatrixInterface<double> matrix, double scalar)
        {
            var result = new Matrix2DType<double>(matrix.Rows, matrix.Columns);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    result.Set(i, j, matrix.Get(i, j) + scalar);
                }
            }
            return result;
        }
    }
}