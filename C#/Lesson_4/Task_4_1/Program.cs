// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int i = 0;
int rezalt = 1;

Console.WriteLine(Degree(a,b));
void Degree(int a, int b)
{
while (i < b)
{
  rezalt*=a;
  i++;
  return rezalt;
}
}
//Console.WriteLine(rezalt);