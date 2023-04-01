// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// //заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите четыре координаты");
Console.Write("Координата b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Координата k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] result = IntersectionPoint(b1, k1, b2, k2);

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
} 
else if (k1==k2)
{
    Console.WriteLine("Прямые параллельны"); 
}
else 
{
PrintIntersectionPoint(IntersectionPoint(b1, k1, b2, k2));
}
double [] IntersectionPoint(int b1, int k1, int b2, int k2)
{
    double left = k1 + (k2*(-1));
    double right = b2 + (b1*(-1));
    double x_0 = right / left;
    double y_0 = k1 * x_0 + b1;
    return new double [] {(x_0), (y_0)};
}  

void PrintIntersectionPoint(double [] result)
{
    Console.Write("Координаты пересечения: ");
    foreach (double item in result)
        Console.Write(item +" ");
}
