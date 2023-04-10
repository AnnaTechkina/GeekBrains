// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[rows, cols];


FillingArray(array);
PrintArray(array);
Console.WriteLine();
MinSumArrayRow(array);

void FillingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}


void PrintArray(int[,] array)
{
    Console.WriteLine("Исходный массив");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
            Console.WriteLine();
    }
}

void MinSumArrayRow(int[,] array)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int s = 0;
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            s += array[i, j];
        }
        if (i == 0) 
        {
            minsum = s;
        }
        else if (s < minsum)
        {
            minsum=s;
            index = i;
        }
    }
    Console.WriteLine($"Минимальная сумма {minsum}, строка {index + 1}");              
}
