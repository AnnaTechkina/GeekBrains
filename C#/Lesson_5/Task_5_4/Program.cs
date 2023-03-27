double ArrayMedian(int[] array)
{
    if (array.Length % 2 == 1) {
        return array[array.Length / 2];
    }
    else 
        return (array[array.Length / 2] + array[(array.Length / 2) - 1]) * 0.5;
}


void FillingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1,50);
}


void PrintArray(int[] array)
{
  foreach (int item in array) Console.Write($"{item} ");
  Console.WriteLine();
}


int[] ResultArray(int[] array)
{
    return new int[] {array[array.Length - 1], array.Length - 1, array[0], 0};
} 


void PrintResultArray(int[] array)
{
    Console.WriteLine();

    int[] res = ResultArray(array);
    Console.WriteLine($"Max: {res[0]}");
    Console.WriteLine($"Index of max: {res[1]}");
    Console.WriteLine($"Min: {res[2]}");
    Console.WriteLine($"Index of min: {res[3]}");

    Console.WriteLine($"Median: {ArrayMedian(array)}");
}



Console.WriteLine("Введите кол-во элементов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

FillingArray(array);
Array.Sort(array);
PrintArray(array);
PrintResultArray(array);
