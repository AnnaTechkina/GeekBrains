// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.[3 7 22 2 78] -> 76
DifferenceNumbers();

void DifferenceNumbers()
{
  double maxnum = 0;
  double minnum = 0;
  double rezalt = 0;

  Random Rand = new Random();
  double[ ] array = new double[10];
  
  for (int i = 0; i < array.Length; i++) 
    array[ i ] = Rand.Next(-100, 100) + Rand.NextDouble();

  foreach (double item in array) 
    Console.Write("{0,8:F2}", item);

  Console.WriteLine();

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]>maxnum)  maxnum = array[i];

    else maxnum=maxnum;
  }
  
  Console.WriteLine();

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]<minnum)  minnum = array[i];

    else minnum=minnum;
  } 
  rezalt = maxnum - minnum;
  Console.Write("{0,2:F2}", rezalt);
  }