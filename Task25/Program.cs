// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.WriteLine("Пользователь, введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пользователь, введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i=1; i<B; i++) {
    result*=A;
}
Console.WriteLine(A+","+B+" -> "+ result);