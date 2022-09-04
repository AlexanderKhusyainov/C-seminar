// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Привет пользователь, введи число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 2;
while (num1 >= num2)
{
    Console.Write(num2+" ");
    num2 = num2 + 2;
}





















