// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.Write("Пользователь, введите число для вывода таблицы кубов чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result;
Console.Write(num+" ->");
while (count <= num)
{
    result = count * count * count;
    if (count == num) {
        Console.Write($" {result} ");
    } else {
        Console.Write($" {result}, ");
    }
    count ++;   
}
Console.WriteLine();