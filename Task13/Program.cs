// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
Console.Write("Пользователь, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99)
Console.WriteLine("Третьей цифры нет");
while (num >= 999)
{
    num = num / 10;
}
int win;
win = num % 10;
Console.WriteLine(win);





// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// int firstDigit = number / 100; 
// int secondDigit = number % 10;
// Console.WriteLine($"число {number} без средней цифры -> {firstDigit}, {secondDigit}");

// int number = new Random().Next(100, 1000);

// int MaxDigit(int num)
// {
//     int firstDigit = num / 100 * 10;
//     int secondDigit = num % 10;    
//     return firstDigit + secondDigit;
// }
// int result = MaxDigit(number);
// Console.WriteLine($"{number} -> {result}");

// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }