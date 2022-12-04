/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
*/


void printRange(int index)
{
    if (index != 0 )
    {
             Console.Write(index + ",");
             printRange(index - 1);
    }
} 
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

printRange(N);