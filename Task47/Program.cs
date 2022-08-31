//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matr = FillMatrix(m, n, -10, 10);
PrintMatrix(matr);

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
    Console.WriteLine();
    }
}

double[,] FillMatrix(int rowsCount, int columonsCount, int leftRange, int rightRange)
{
    double[,] matrix = new double[rowsCount,columonsCount];
    Random rand = new Random();

    for(int i=0; i < matrix.GetLength(0); i++)
    {
        for(int j=0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange,rightRange);
        }
    }

    return matrix;
}