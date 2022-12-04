// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int AkkermanFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkermanFunction(m - 1, 1);
    else
      return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
Console.Write("Значение N: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Значение M: "); 
int N = Convert.ToInt32(Console.ReadLine()); 

Console.Write($"Результат: {AkkermanFunction(M, N)} ");