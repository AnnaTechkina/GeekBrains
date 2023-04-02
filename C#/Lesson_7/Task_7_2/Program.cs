//Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:1 4 7 2
                      // 5 9 2 3
                      // 8 4 2 4   17 -> такого числа в массиве нет;

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];
int count = 0;
Console.WriteLine("Введите искомое число: ");
int find = Convert.ToInt32(Console.ReadLine());

FillingArray(array);
PrintArray(array);
NumberSearch(array,find);

void FillingArray(int[,]array)
{
  for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = new Random().Next(-10,10);
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i,j],3}\t");
    Console.WriteLine();
  }
}

void NumberSearch(int[,] array, int find)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (array[i,j] == find)
        {
          count++;
Console.Write($"позиция элемента {find} [{i},{j}]"+" ");    
        }
      } 
    } 
    if (count > 0) Console.WriteLine($"количество вхождений -{count}"); 
    else Console.WriteLine("Такого элемента нет");    
}