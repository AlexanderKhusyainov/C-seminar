// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
double[] arr = new double[5];

void FillArray(double[] array) {
    int count = array.Length;
    for (int i = 0; i < count;i++)
    {
        array[i] = new Random().NextDouble();
    }
}

void PrintArray(double[] array) {
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

void SummArray(double[] array) {
double result;
double max = 0;
double min = array[0];
    for(int i = 0; i < arr.Length; i=i+1) {
        if (arr[i]>max) {
            max = arr[i];
        }
        if (arr[i]<min) {
            min = arr[i];
        }     
    }
    result = max - min;
    Console.WriteLine($" -> {result}");  
}

FillArray(arr);
PrintArray(arr);
SummArray(arr);