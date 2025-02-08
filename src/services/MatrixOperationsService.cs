using MatrixOperationsLibrary.Interfaces;

namespace MatrixOperationsLibrary.Services
{
    public class MatrixOperationsService<T> : IMatrixOperationsService<T>
    {
        private readonly IMatrixDotProductAlgorithm<T> _dotProductAlgorithm;
        private readonly IMatrixCrossProductAlgorithm<T> _crossProductAlgorithm;
        private readonly IMatrixSumAlgorithm<T> _sumAlgorithm;
        private readonly IMatrixScalarOperationsAlgorithm<T> _scalarOperationsAlgorithm;

        public MatrixOperationsService(
            IMatrixDotProductAlgorithm<T> dotProductAlgorithm,
            IMatrixCrossProductAlgorithm<T> crossProductAlgorithm,
            IMatrixSumAlgorithm<T> sumAlgorithm,
            IMatrixScalarOperationsAlgorithm<T> scalarOperationsAlgorithm)
        {
            _dotProductAlgorithm = dotProductAlgorithm;
            _crossProductAlgorithm = crossProductAlgorithm;
            _sumAlgorithm = sumAlgorithm;
            _scalarOperationsAlgorithm = scalarOperationsAlgorithm;
        }

        public T DotProduct(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB)
        {
            return _dotProductAlgorithm.Calculate(matrixA, matrixB);
        }

        public IMatrixInterface<T> CrossProduct(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB)
        {
            return _crossProductAlgorithm.Calculate(matrixA, matrixB);
        }

        public IMatrixInterface<T> Sum(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB)
        {
            return _sumAlgorithm.Calculate(matrixA, matrixB);
        }

        public IMatrixInterface<T> ScalarMultiply(IMatrixInterface<T> matrix, T scalar)
        {
            return _scalarOperationsAlgorithm.Multiply(matrix, scalar);
        }

        public IMatrixInterface<T> ScalarAdd(IMatrixInterface<T> matrix, T scalar)
        {
            return _scalarOperationsAlgorithm.Add(matrix, scalar);
        }
    }
}