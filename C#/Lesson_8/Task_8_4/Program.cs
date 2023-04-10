// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

int[,,] matrix = {
                  {
                    {98,25},
                    {34,35}
                  },
                  {
                    {69,11},
                    {26,74}
                  }
                  };

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write($"{matrix[i, j, k]} {(i, j, k)}" + " " );
        }
        Console.WriteLine();
    }
}


                
                
    