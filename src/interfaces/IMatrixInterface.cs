namespace MatrixOperationsLibrary.Interfaces
{
    public interface IMatrixInterface<T>
    {
        int Rows { get; }
        int Columns { get; }

        void Initialize(int rows, int columns);
        void Set(int row, int col, T value);
        T Get(int row, int col);
        IMatrixInterface<T> Transpose();
        double Determinant();
    }
}