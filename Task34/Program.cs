// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] arr = new int[4];

void FillArray(int[] array) {
    int count = array.Length;
    for (int i = 0; i < count;i++)
    {
        array[i] = new Random().Next(100,999);
    }
}

void PrintArray(int[] array) {
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

void ResultArray(int[] array) {
int result = 0;
    for(int i = 0; i < arr.Length; i++) {
        int a = arr[i];
        if (a % 2 == 0) {
            result = result + 1;
        }       
    }
    Console.WriteLine($" -> {result}, ");  
}

FillArray(arr);
PrintArray(arr);
ResultArray(arr);
