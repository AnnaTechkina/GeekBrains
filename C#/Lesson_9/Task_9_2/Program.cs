// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(SumNumber(m,n));


int SumNumber(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + SumNumber(m, n - 1); 
    else return n + SumNumber(m, n + 1);           
}