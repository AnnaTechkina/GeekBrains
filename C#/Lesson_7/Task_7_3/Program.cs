// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows,cols];

FillingArray(array);
PrintArray(array);
ArithmeticMean(array);

void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double results = 0;
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            results = sum / array.GetLength(0);
        }
        Console.Write($"{results:F2}\t");
    }
}

void FillingArray(int[,]array)
{
  for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = new Random().Next(-50,50);
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


