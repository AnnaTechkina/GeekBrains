//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

//Объявление переменных
Console.WriteLine("Введите количество строк");
int count = Int32.Parse(Console.ReadLine());
string[] Array1 = new string[count];
int index = 0;
string[] Array2 = new string[count];


//Вызов функций
FillArray(Array1);
PrintArray(Array1);
ArrayResult(Array1);
PrintArray(Array2);

string[] FillArray(string [] Array1)// Набор элементов массива с клавиатуры
{
        Console.WriteLine("Введите строки");
        for (int i = 0; i < Array1.Length; i++)
        {
            Console.Write("строка {0} = ", i + 1);
            Array1[i] = Console.ReadLine();
        }
        return Array1;
}

void PrintArray(string[] Array)// вывод массивов на экран
{
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write($"{Array[i]} ");
        }
        Console.WriteLine();
}

string[] ArrayResult(string[] array)// результирующий массив
{
        for (int i = 0; i < Array1.Length; i++)
        {
            if(Array1[i].Length <= 3)
            {
                Array2[index] = Array1[i];   
                index++;
            }
        }
        return Array2;
}
