/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

/*void ArrayN(int n) //печатет маасив размера n, с введенными с клавиатуры строками
{
  Console.WriteLine("Enter strings: ");
  string [] arr = new string[n];

  for (int i = 0; i < n; i++ )

    {
     Console.Write("Введите строку: ");
      arr[i] = Console.ReadLine(); 
    }
    Console.WriteLine("Вы ввели следующие строки:");
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine(arr[i]);
    }
    
}
*/

/*string ArrayN(int n) // формирует маасив размера n, с введенными с клавиатуры строками

{
  Console.WriteLine("Enter strings: ");
  string [] arr = new string[n];

  for (int i = 0; i < n; i++ )

    {
          arr[i] = Console.ReadLine(); 
    }
    return arr[n];
}
*/

/*void NewArray(int n, string []array2)//из имеющегося массива в n строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам
{
  Console.WriteLine("Enter strings: ");
  string [] arr = new string[n];

  for (int i = 0; i < n; i++ )

    {
          arr[i] = Console.ReadLine(); 
    }
   
  int count = 0;
  for ( int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length < 4)
    {
      array2[count] = arr[i];
    }
    else
    {
     array2[count] = (" ");
    }
    count++;
  }
   Console.Write("[");
  for ( int k = 0; k < array2.Length; k++)
  {
   if (array2[k] != (" "))
    {
       Console.Write($"{array2[k]} ");
    }
  }
Console.Write("]");
}*/
void NewArray(int n)
{
  Console.WriteLine("Enter strings: ");
  string [] arr = new string[n];
  int index = 0;
  for (int i = 0; i < n; i++ )
    {
          arr[i] = Console.ReadLine(); 
          if (arr[i].Length < 4)
          {
            index++;
          }
    }
      string [] array = new string[index];
  int count = 0;
  for ( int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length < 4)
    {
      array[count] = arr[i];
       count++;
    }
       
  }
   Console.Write("[");
  for ( int k = 0; k < array.Length; k++)
  {
   if (array[k] != (" "))
    {
       Console.Write($"{array[k]} ");
    }
  }
Console.Write("]");
}

Console.Write("Enter the number of strings: ");
int N = Convert.ToInt32(Console.ReadLine());
NewArray(N);