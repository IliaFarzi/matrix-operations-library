namespace MatrixOperationsLibrary.Interfaces
{
    public interface IMatrixSumAlgorithm<T>
    {
        IMatrixInterface<T> Calculate(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB);
    }
}