﻿// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


Console.Clear();
Console.WriteLine("Решаем задачу 60");

int[,,] CreateMatrixRndInt (int a, int b, int c, int min, int max) 
{
    int[,,] matrix = new int[a, b, c];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i,j,k] = rnd.Next(min, max + 1);
                }
        }
    }
    return matrix;
} 

 
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k], 1}({i},{j},{k})  ");            
            }
        }
        Console.WriteLine();        
    }        
}


int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10, 99);
Console.WriteLine("вывод массива");
PrintMatrix(array3D);











