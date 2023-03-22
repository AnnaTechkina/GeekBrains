// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите числа: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;


summ(num);
void summ(int num)
{
  while (num > 0)
  {
    sum += num%10;
    num /= 10;
  }
  Console.WriteLine(sum);
}
