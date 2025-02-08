namespace MatrixOperationsLibrary.Interfaces
{
    public interface IMatrixDotProductAlgorithm<T>
    {
        T Calculate(IMatrixInterface<T> matrixA, IMatrixInterface<T> matrixB);
    }
}