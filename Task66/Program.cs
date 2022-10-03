// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int M = Numbers("Пользователь, введите M: ");
int N = Numbers("Пользователь, введите N: ");
int temp = M;

if (M> N) 
{
  M = N; 
  N = temp;
}

PrintResult(M, N, temp = 0);

void PrintResult(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"-> {summ} ");
    return;
  }
  PrintResult(M, N - 1, summ);
}

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
