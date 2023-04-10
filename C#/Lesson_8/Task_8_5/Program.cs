// Напишите программу, которая заполнит спирально массив 4 на 4.
string[,] mas = new string[6,6];
FillSpiral(mas);
PrintArray(mas);

string ToString(int value) => Convert.ToString(value);
int AmoutArrayElem(string[,] mas) => (mas.GetLength(0) - 2) * (mas.GetLength(1) - 2);

void FillSpiral(string[,] array)
{
  int number = 0;
  int row = 1, col = 0;

  for (int i = 0; i < array.GetLength(0); i++)
      for (int j = 0; j < array.GetLength(1); j++)
          array[i,j] = "-1";
  
  for (int i = 1; i < array.GetLength(0) - 1; i++)
      for (int j = 1; j < array.GetLength(1) - 1; j++)
          array[i,j] = "0";

  while (number < AmoutArrayElem(array))
  {
      while (array[row, col + 1] == "0") // двигаемся вправо, пока можем
      {
          col++;
          number++;
          if (ToString(number).Length < 2) array[row, col] = $"0{number}";
          else array[row, col] = $"{number}";
      }
      while (array[row + 1,col] == "0")// двигаемся вниз, пока можем
      {
        row++;
        number++;
        if (ToString(number).Length < 2) array[row, col] = $"0{number}";
        else array[row, col] = $"{number}";
      }
      while (array[row,col - 1] == "0")// двигаемся влево, пока можем
      {
        col--;
        number++;
        if (ToString(number).Length < 2) array[row, col] = $"0{number}";
        else array[row, col] = $"{number}";
      }
      while (array[row - 1,col] == "0")// двигаемся вверх, пока можем
      {
        row--;
        number++;
        if (ToString(number).Length < 2) array[row, col] = $"0{number}";
        else array[row, col] = $"{number}";
      }
    }
}

void PrintArray(string[,] array)
{
    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < array.GetLength(1) - 1; j++)
            Console.Write($"{array[i,j],3}");
        Console.WriteLine();
    }
}