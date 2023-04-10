//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив: 1 4 7 2       7 4 2 1  В итоге получается вот такой массив:      
// 5 9 2 3       9 5 3 2
// 8 4 2 4       8 4 4 2

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[rows, cols];
FillingArray(nums);
Console.WriteLine("Исходный массив");
PrintArray(nums);
Console.WriteLine("Отсортированный массив");
MySortArray(nums);
PrintArray(nums);




void FillingArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(0, 10);
}


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j],3}\t");
    Console.WriteLine();
  }
}


void MySortArray(int[,] mas)
{
  for (int i = 0; i < mas.GetLength(0); i++)
    for (int j = 0; j < mas.GetLength(1)-1; j++)
      for (int k = j + 1; k < mas.GetLength(1); k++)
        if (mas[i, j] < mas[i, k])
        {
          int temp = mas[i, j];
          mas[i, j] = mas[i, k];
          mas[i, k] = temp;
        }
}

