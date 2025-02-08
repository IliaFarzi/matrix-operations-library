namespace MatrixOperationsLibrary.Interfaces
{
    public interface IMatrixScalarOperationsAlgorithm<T>
    {
        IMatrixInterface<T> Multiply(IMatrixInterface<T> matrix, T scalar);
        IMatrixInterface<T> Add(IMatrixInterface<T> matrix, T scalar);
    }
}