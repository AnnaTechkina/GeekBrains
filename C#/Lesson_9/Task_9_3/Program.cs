// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите первое неотрицательное число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(Ackerman(m,n));


int Ackerman (int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return Ackerman(m-1, 1);
    else  return Ackerman(m - 1, Ackerman(m, n - 1));
}

