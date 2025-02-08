namespace MatrixOperationsLibrary.Interfaces
{
    public interface IMatrixOperationsService<T>
    {
        T DotProduct(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB);
        IMatrixInterface<T> CrossProduct(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB);
        IMatrixInterface<T> Sum(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB);
        IMatrixInterface<T> ScalarMultiply(IMatrixInterface<T> matrix, T scalar);
        IMatrixInterface<T> ScalarAdd(IMatrixInterface<T> matrix, T scalar);
    }
}