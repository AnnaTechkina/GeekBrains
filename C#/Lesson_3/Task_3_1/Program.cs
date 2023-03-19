Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrom(int number)
{
    if(number >= 10000)
    {
        int first_number1 = number / 10000;
        int last_number1 = number % 10;
 
            if(first_number1 == last_number1)
            {
                number = number / 10;
                int first_number2 = (number / 100)%10;
                int last_number2 = number % 10;
                if(first_number2 == last_number2)
                    Console.WriteLine("Число является палиндром");
            }
            else 
            Console.WriteLine("Число не является палиндромом"); 
    }
    else
    Console.WriteLine("Нужно ввести пятизначное число");
}

Palindrom(number);
