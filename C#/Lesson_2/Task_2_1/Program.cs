Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int rez = 0;

if (Num < 10)
  Console.WriteLine("нет");
else
    while (Num > 100) 
      Num = Num / 10;
    rez = Num % 10;
    
Console.WriteLine(rez);