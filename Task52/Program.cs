//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = FillMatrix(m, n, 1, 10);


AvgMatrix(matr);
Console.WriteLine();

PrintMatrix(matr);

void PrintMatrix(int[,] matrix)
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

int[,] FillMatrix(int rowsCount, int columonsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columonsCount];
    Random rand = new Random();

    for(int i=0; i < matrix.GetLength(0); i++)
    {
        for(int j=0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange,rightRange);
        }
    }
    Console.WriteLine();
    return matrix;
}

void AvgMatrix(int[,] matrix)
{
    double avg = 0;
    for(int i=0; i < matrix.GetLength(1); i++)
    {
        for(int j=0; j < matrix.GetLength(0); j++)
        {
            avg += matrix[j,i];
        }
        avg/= matrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое в столбце {i} равно {avg}");
        avg = 0;
    }  
}