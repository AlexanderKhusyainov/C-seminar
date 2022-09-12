// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Clear();
Console.Write("Пользователь, введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());
int ostatok;
int sum = 0;
Console.Write(num);
while (num >0) {
    ostatok = num % 10;
    num/= 10;
    sum+= ostatok;
}
Console.WriteLine(" -> "+sum);