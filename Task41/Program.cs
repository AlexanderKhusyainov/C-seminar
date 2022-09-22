// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Пользователь, введи числа, используя пробел на клавиатуре: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int win = 0;
for (int i = 0; i < arr.Length; i++) {
    if (arr[i] > 0)
    {
        win++;
    }
}
Console.WriteLine($"Кол-во чисел, введенных пользователем больше 0 ->  {win}  ");
