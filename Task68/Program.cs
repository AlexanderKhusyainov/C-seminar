// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int M = Numbers("Пользователь, введите M: ");
int N = Numbers("Пользователь, введите N: ");

int Akkerman(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Akkerman(M - 1, 1);
  else return Akkerman(M - 1, Akkerman(M, N - 1));
}

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int function = Akkerman(M, N);
Console.Write($"A(M,N) = {function} ");