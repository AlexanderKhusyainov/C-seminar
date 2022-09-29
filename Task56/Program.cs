// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //0, 1, 2

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

void SumLine (int[,] matrix)
{
    int index = 0;
    int minsumm = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ+= matrix[i,j];
        }
        // Console.WriteLine($"сумма {i + 1} строки массива = {summ}");
        if (i==0)
        {
            minsumm = summ;
        }
        else if (summ<minsumm)
        {
            minsumm = summ;
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов ->> {index+1} <<-");  
}        

int[,] array2D = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(array2D);
SumLine(array2D);