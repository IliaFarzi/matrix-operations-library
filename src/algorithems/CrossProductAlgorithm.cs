using System;
using MatrixOperationsLibrary.Interfaces;
using MatrixOperationsLibrary.Types;

namespace MatrixOperationsLibrary.Algorithms
{
    public class CrossProductAlgorithm : IMatrixCrossProductAlgorithm<double>
    {
        public IMatrixInterface<double> Calculate(IMatrixInterface<double> matrixA, IMatrixInterface<double> matrixB)
        {
            if (!IsVector(matrixA) || !IsVector(matrixB) || matrixA.Rows != 3 || matrixB.Rows != 3)
                throw new InvalidOperationException("Cross product is only defined for 3D vectors.");

            var result = new Matrix2DType<double>(3, 1);
            
            result.Set(0, 0, matrixA.Get(1, 0) * matrixB.Get(2, 0) - matrixA.Get(2, 0) * matrixB.Get(1, 0));
            result.Set(1, 0, matrixA.Get(2, 0) * matrixB.Get(0, 0) - matrixA.Get(0, 0) * matrixB.Get(2, 0));
            result.Set(2, 0, matrixA.Get(0, 0) * matrixB.Get(1, 0) - matrixA.Get(1, 0) * matrixB.Get(0, 0));

            return result;
        }

        private bool IsVector(IMatrixInterface<double> matrix)
        {
            return matrix.Columns == 1 || matrix.Rows == 1;
        }
    }
}