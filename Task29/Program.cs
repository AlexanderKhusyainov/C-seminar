﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int [] array = new int [8];
Random rand = new Random();
for (int i =0; i < 8; i++) {
    array[i] = new Random().Next(0,99);
}
int count = array.Length;
Console.Write("[");
for (int i = 0; i < count;i++) {
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("]");
