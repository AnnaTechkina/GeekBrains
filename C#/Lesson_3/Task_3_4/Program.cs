//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
//Сначала задается N с клавиатуры, потом задаются координаты точек
Console.Write("Введите в каком пространстве находятся координаты: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 2)
{
    Console.WriteLine("Введите координаты: ");
    int x_1 = Convert.ToInt32(Console.ReadLine());
    int y_1 = Convert.ToInt32(Console.ReadLine());
    int x_2 = Convert.ToInt32(Console.ReadLine());
    int y_2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(DistanceBetweenPoint(x_1,x_2,y_1,y_2));
    double DistanceBetweenPoint(int x_1,int x_2, int y_1, int y_2)
    {
        double resalt = Math.Sqrt(Math.Pow((x_2 - x_1),2) + Math.Pow((y_2 - y_1),2));
        return resalt;
    }
}
else
{
    Console.WriteLine("Введите координаты: ");
    int x_1 = Convert.ToInt32(Console.ReadLine());
    int y_1 = Convert.ToInt32(Console.ReadLine());
    int x_2 = Convert.ToInt32(Console.ReadLine());
    int y_2 = Convert.ToInt32(Console.ReadLine());
    int z_1 = Convert.ToInt32(Console.ReadLine());
    int z_2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(DistanceBetweenPoint_3(x_1,x_2,y_1,y_2,z_1,z_2));
    double DistanceBetweenPoint_3(int x_1,int x_2, int y_1, int y_2, int z_1, int z_2)
    {
        double resalt2 = Math.Sqrt(Math.Pow((x_2 - x_1),2) + Math.Pow((y_2 - y_1),2) + Math.Pow((z_2 - z_1),2));
        return resalt2;
    }
}

