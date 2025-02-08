namespace MatrixOperationsLibrary.Interfaces
{
    public interface IMatrixCrossProductAlgorithm<T>
    {
        IMatrixInterface<T> Calculate(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB);
    }
}