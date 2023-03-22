// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2

int[] array = new int[4];
FillingArray(array);
PrintArray(array);
EvenNumbers(array);

void FillingArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100,999);
  }
}

void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    Console.Write($"{item}"+" ");
  }
  Console.WriteLine();
}

void EvenNumbers(int[] array)
{
  int count = 0;
  foreach (int item in array)
  {
    if(item%2 ==0)
        count++;   
  }
Console.WriteLine(count);
}
