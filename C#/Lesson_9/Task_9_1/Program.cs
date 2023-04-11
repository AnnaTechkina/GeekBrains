// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


Console.WriteLine(nums(n));

int nums(int n)
{
    if (n == 0) return 0;
    Console.WriteLine(n);
    return nums(n-1);    
}
    
