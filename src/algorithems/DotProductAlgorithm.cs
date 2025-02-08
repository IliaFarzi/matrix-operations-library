using System;
using MatrixOperationsLibrary.Interfaces;

namespace MatrixOperationsLibrary.Algorithms
{
    public class DotProductAlgorithm : IMatrixDotProductAlgorithm<double>
    {
        public double Calculate(IMatrixInterface<double> matrixA, IMatrixInterface<double> matrixB)
        {
            if (matrixA.Rows != matrixB.Rows || matrixA.Columns != matrixB.Columns)
                throw new InvalidOperationException("Matrices must have the same dimensions for dot product.");

            double result = 0;
            for (int i = 0; i < matrixA.Rows; i++)
            {
                for (int j = 0; j < matrixA.Columns; j++)
                {
                    result += matrixA.Get(i, j) * matrixB.Get(i, j);
                }
            }
            return result;
        }
    }
}