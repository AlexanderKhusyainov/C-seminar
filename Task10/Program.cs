// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Пользователь, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1000 && num > 99)
{
    num = (num / 10) % 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Ошибка, введите число из 3х знаков");
}