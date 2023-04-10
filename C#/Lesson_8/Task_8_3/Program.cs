// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Матрица 1");
Console.WriteLine("Введите количество строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[rows1, cols1];

Console.WriteLine("Матрица 2");
Console.WriteLine("Введите количество строк: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[rows2, cols2];


if (rows1 == cols2 && cols1 == rows2)
{
    FillMatrix(matrix1);
    Console.WriteLine("Матрица 1");
    PrintMatrix(matrix1);
    FillMatrix(matrix2);
    Console.WriteLine("Матрица 2");
    PrintMatrix(matrix2);
    int[,] res = ComposMatrix(matrix1,matrix2);
    Console.WriteLine("Результирующая Матрица ");
    PrintMatrix(res);

    void FillMatrix(int[,] matrix1)
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                matrix1[i, j] = new Random().Next(0, 6);
    }

    void PrintMatrix(int[,] matrix1)
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
                Console.Write($"{matrix1[i, j],3}\t");
                Console.WriteLine();
        }
    }
   
    int[,] ComposMatrix(int[,] matrix1, int[,] matrix2)
    {
        int[,]rezmatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int row = 0; row < matrix1.GetLength(0); row++)
            for (int col = 0; col < matrix2.GetLength(1); col++)
                for (int inner = 0; inner < matrix1.GetLength(1); inner++)
                    rezmatrix[row, col] += matrix1[row,inner] * matrix2[inner, col];
    
    return rezmatrix;
    }
}
else Console.WriteLine("число строк matrix1 должно быть равно числу столбцов matrix2");