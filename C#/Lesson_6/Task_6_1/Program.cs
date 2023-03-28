// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//5 //0, 7, 8, -2, -2 -> 2
//5 //1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество цифр: ");
int m = Convert.ToInt32(Console.ReadLine());
int[]array = new int [m];
int count = 0;

FillingArray(array);
PrintArray(array);
Console.WriteLine(ResultsArray(array));


int ResultsArray(int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+=1;
    }       return count;
}

void PrintArray(int[] array)
{
    foreach (int item in array) Console.Write(item + " ");
}
Console.WriteLine();

void FillingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-100, 300);
}



