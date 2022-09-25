// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrixDouble = new double[rows, columns];

    Random random = new Random();
    for (int i = 0; i < matrixDouble.GetLength(0); i++)
    {
        for (int j = 0; j < matrixDouble.GetLength(1); j++)
        {
             matrixDouble[i,j] = random.NextDouble()*10;
        }
    }
    return matrixDouble;
}

void PrintMatrix(double[,] matrixDouble)
{
    for (int i = 0; i < matrixDouble.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrixDouble.GetLength(1); j++)
        {
            if (j < matrixDouble.GetLength(1) - 1) Console.Write($"{matrixDouble[i, j], 5}, ");
            else Console.Write($"{matrixDouble[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}
double [,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);