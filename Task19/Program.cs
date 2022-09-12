// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.Write("Пользователь, введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());
int num3 = num;
int b =0;
String chislo = "";
while (num >= 1) {
    b =num % 10;
    num = num / 10;
    chislo= chislo + b;
}
int win;
win = num % 10;
int num2 = Convert.ToInt32(chislo);
if (num2 == num3) {
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");   
}





