Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int rez = 0;
int rez1 = 0;

if (Num < 100)
{
  Console.WriteLine("третьей цифры нет");
}
else if (Num < 1000)
{
  rez1 = Num % 10;
  Console.WriteLine(rez1);
}
else
{
  while (Num > 1000)
  {
    Num = Num / 10;
    rez = Num % 10;
  }
  Console.WriteLine(rez);
}

