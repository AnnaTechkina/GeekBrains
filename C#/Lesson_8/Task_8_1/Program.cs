//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив: 1 4 7 2       7 4 2 1  В итоге получается вот такой массив:      
                       // 5 9 2 3       9 5 3 2
                       // 8 4 2 4       8 4 4 2
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

NumberSearch(args);

int[,] FillingArray(int rows, int cols)
{
  int[,] array = new int [rows,cols];
  for (int i = 0; i < rows; i++)
  {
      for (int j = 0; j < cols; j++)
      {
        array[i,j] = new Random().Next(0,10);
      }
  }
  return array;
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

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length-i-1; j++)
        {
            if(array[j] < array[j+1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}

void NumberSearch(string[] args)
{
    int colCount = cols;
    int rowCount = rows;
    int[,] arr = FillingArray(rowCount,colCount);

    Console.WriteLine("Исходный массив");
    PrintArray(arr);

    Console.WriteLine("Сортировка по строкам");
    int[] row = new int[colCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
            row[j] = arr[i,j];
        SortArray(row);
        Insert(true, i, row, arr);
    }
    PrintArray(arr);

    Console.WriteLine("Сортировка по столбцам");
    int[] col = new int[colCount];
    for (int i = 0; i < colCount; i++)
    {
        for (int j = 0; j < rowCount; j++)
            col[j] = arr[j,i];
        SortArray(col);
        Insert(false, i, col, arr);
    }
    PrintArray(arr);
}
void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}
