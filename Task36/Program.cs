// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] arr = new int[4];

void FillArray(int[] array) {
    int count = array.Length;
    for (int i = 0; i < count;i++)
    {
        array[i] = new Random().Next(-10,10);
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

void SummArray(int[] array) {
int result = 0;
    for(int i = 1; i < arr.Length; i=i+2) {
        result = result + arr[i];      
    }
    Console.WriteLine($" -> {result}");  
}

FillArray(arr);
PrintArray(arr);
SummArray(arr);