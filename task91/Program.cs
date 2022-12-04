//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/* Способ без рекурсии
int SumNutDidgit(int M, int N)
{
    int sum = 0;
    if (M < N)
    {
        for (int i = M; i <= N; i++)
        {
            sum = sum + i;
        }
    }
    else
    {

        for (int i = N; i <= M; i++)
        {
            sum = sum + i;
        }

    }
    return sum;
}
Console.Write("Enter the first number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNutDidgit(M, N));*/

int SumNutDidgit(int M, int N) 
{ 
    //int Sum = 0;
    if (N == M) 
    { 
        return M; 
    } 
    return SumNutDidgit(M, N-1) + N; 
    
} 
Console.Write("Enter the first number: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the second number: "); 
int N = Convert.ToInt32(Console.ReadLine()); 
if (M > N) 
{ 
    Console.WriteLine(SumNutDidgit(N, M)); 
} 
else 
{ 
    Console.WriteLine(SumNutDidgit(M, N)); 
}