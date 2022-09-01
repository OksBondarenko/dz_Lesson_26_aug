// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

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

int[,] matr = FillMatrix(m, n, 1, 10);

Console.WriteLine("Напишите искомую стоку: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите искомый столбец: ");
int j = Convert.ToInt32(Console.ReadLine());

if(i > m-1 || j > n-1)
{
    Console.WriteLine("Данного элемента в массиве нет");
    Console.WriteLine();
}
else
{
    Console.WriteLine($"Значение искомого элемента равно: {matr[i,j]}");
    Console.WriteLine();
}

PrintMatrix(matr);