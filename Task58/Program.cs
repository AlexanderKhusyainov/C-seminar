// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixRndInt(2, 2, 1, 3);
int[,] array1D = CreateMatrixRndInt(2, 2, 1, 3);
int[,] resultArray = new int[2,2];
PrintMatrix(array2D);
Console.WriteLine();
PrintMatrix(array1D);
Console.WriteLine();



if (array2D.GetLength(0) != array1D.GetLength(1))
{
    Console.WriteLine(" Нет ");
    return;
}
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array1D.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array1D.GetLength(1); k++)
        {
            resultArray[i, j] += array2D[i, k] * array1D[k, j];
        }
    }
}
PrintMatrix(resultArray);
