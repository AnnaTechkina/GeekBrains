// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int [8];
int sum = 0;
RandomNumbers(array);
PrintArray(array);
SumArray(array);

void RandomNumbers(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-20,20);
  }
}

void PrintArray(int[] array)
{
  foreach(int item in array)
  {
    Console.Write($"{item}" + " ");
  }
  Console.WriteLine(" ");
}

void SumArray(int[] array)
{
  for (int j = 0; j < array.Length; j++)
  {
    if (j % 2 ==0) sum += array[j]; 
  }
  Console.WriteLine(sum);
}
