// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.Write("Пользователь, введите число, соответствующее дню недели и ты узнаешь, выходной ли этот день: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1)
// {
// Console.WriteLine($"нет");
// }
// if (num == 2)
// {
// Console.WriteLine($"нет");
// }
// if (num == 3)
// {
// Console.WriteLine($"нет");
// }
// if (num == 4)
// {
// Console.WriteLine($"нет");
// }
// if (num == 5)
// {
// Console.WriteLine($"нет");
// }
// if (num == 6)
// {
// Console.WriteLine($"да");
// }
// if (num == 7)
// {
// Console.WriteLine($"да");
// }
// if (num > 7)
// Console.WriteLine("Пользователь, в неделе 7 дней");

Console.Clear();
Console.Write("Пользователь, введите число, соответствующее дню недели и ты узнаешь, выходной ли этот день: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 5)
{
Console.WriteLine($"нет");
}
if (num > 5 && num <= 7)
{
Console.WriteLine($"да");
}
if (num > 7)
Console.WriteLine("Пользователь,увы, в неделе 7 дней");