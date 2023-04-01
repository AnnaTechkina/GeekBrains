// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//5 //0, 7, 8, -2, -2 -> 2
//5 //1, -7, 567, 89, 223-> 3

int numbers = Prompt("Введите количество элементов: ");
int[] array;
array = FillingArray(numbers);
PrintArray(array);
Console.WriteLine($"Количество элементов больше 0 - {ResultsArray(array)}");

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] FillingArray(int numbers)
{
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} - й элемент");    
    }
    return array; 
}

void PrintArray(int[] array)
{
    foreach (int item in array) Console.Write(item + " ");
}
Console.WriteLine();

int ResultsArray(int []array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count+=1;
    }       
    return count;
}









