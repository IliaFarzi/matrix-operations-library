using System;
using MatrixOperationsLibrary.Services;
using MatrixOperationsLibrary.Algorithms;
using MatrixOperationsLibrary.Types;
using MatrixOperationsLibrary.Interfaces;

namespace MatrixConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create matrices
            var matrixA = new Matrix2DType<double>(2, 2);
            matrixA.Set(0, 0, 1);
            matrixA.Set(0, 1, 2);
            matrixA.Set(1, 0, 3);
            matrixA.Set(1, 1, 4);

            var matrixB = new Matrix2DType<double>(2, 2);
            matrixB.Set(0, 0, 5);
            matrixB.Set(0, 1, 6);
            matrixB.Set(1, 0, 7);
            matrixB.Set(1, 1, 8);

            // Initialize algorithms
            var dotProductAlgorithm = new DotProductAlgorithm();
            var crossProductAlgorithm = new CrossProductAlgorithm();
            var sumAlgorithm = new SumAlgorithm();
            var scalarOperationsAlgorithm = new ScalarOperationsAlgorithm();

            // Initialize MatrixOperationsService with algorithms
            var matrixService = new MatrixOperationsService<double>(
                dotProductAlgorithm,
                crossProductAlgorithm,
                sumAlgorithm,
                scalarOperationsAlgorithm
            );

            // Use the service
            double dotProduct = matrixService.DotProduct(matrixA, matrixB);
            Console.WriteLine($"Dot Product: {dotProduct}");

            var sumResult = matrixService.Sum(matrixA, matrixB);
            Console.WriteLine("Matrix Sum:");
            DisplayMatrix(sumResult);

            var scalarMultiplyResult = matrixService.ScalarMultiply(matrixA, 2);
            Console.WriteLine("Scalar Multiplication:");
            DisplayMatrix(scalarMultiplyResult);
        }

        static void DisplayMatrix(IMatrixInterface<double> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write($"{matrix.Get(i, j)} ");
                }
                Console.WriteLine();
            }
        }
    }
}
