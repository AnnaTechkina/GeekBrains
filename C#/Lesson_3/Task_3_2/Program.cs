Console.WriteLine("Введите координаты");
int x_1 = Convert.ToInt32(Console.ReadLine());
int x_2 = Convert.ToInt32(Console.ReadLine());
int y_1 = Convert.ToInt32(Console.ReadLine());
int y_2 = Convert.ToInt32(Console.ReadLine());
int z_1 = Convert.ToInt32(Console.ReadLine());
int z_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CoordinateDistance(x_1,x_2,y_1,y_2,z_1,z_2));
double CoordinateDistance(int x_1, int x_2, int y_1, int y_2, int z_1, int z_2)
{
  double distance = Math.Sqrt(Math.Pow((x_2 - x_1),2) + Math.Pow((y_2 - y_1),2) + Math.Pow((z_2 - z_1),2));
  return distance;
}