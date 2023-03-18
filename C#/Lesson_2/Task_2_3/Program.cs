 //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 7 -> да 1 -> нет
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num == 1)
{
  Console.WriteLine("Понедельник");
}
else if (Num == 2)
{
  Console.WriteLine("Вторник");
}
else if (Num == 3)
{
  Console.WriteLine("Среда");
}
else if (Num == 4)
{
  Console.WriteLine("Четверг");
}
else if (Num == 5)
{
  Console.WriteLine("Пятница");
}
else if (Num == 6)
{
  Console.WriteLine("Суббота,выходной");
}
else if (Num == 7)
{
  Console.WriteLine("Воскресенье, выходной");
}
else
{
  Console.WriteLine("Такого дня нет");
}