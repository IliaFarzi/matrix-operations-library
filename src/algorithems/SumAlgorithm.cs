using System;
using MatrixOperationsLibrary.Interfaces;
using MatrixOperationsLibrary.Types;

namespace MatrixOperationsLibrary.Algorithms
{
    public class SumAlgorithm : IMatrixSumAlgorithm<double>
    {
        public IMatrixInterface<double> Calculate(IMatrixInterface<double> matrixA, IMatrixInterface<double> matrixB)
        {
            if (matrixA.Rows != matrixB.Rows || matrixA.Columns != matrixB.Columns)
                throw new InvalidOperationException("Matrices must have the same dimensions for addition.");

            var result = new Matrix2DType<double>(matrixA.Rows, matrixA.Columns);
            for (int i = 0; i < matrixA.Rows; i++)
            {
                for (int j = 0; j < matrixA.Columns; j++)
                {
                    double sum = matrixA.Get(i, j) + matrixB.Get(i, j);
                    result.Set(i, j, sum);
                }
            }
            return result;
        }
    }
}