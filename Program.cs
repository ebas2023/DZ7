/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество элементов двумерного массива m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество элементов двумерного массива n:");
int n = int.Parse(Console.ReadLine()!);

double [,] matrix =GetArray(m,n);
PrintArray(matrix);

double [,] GetArray(int m, int n)
{
    double [,] matrix=new double[m,n];
    for (int i=0;i<matrix.GetLength (0);i++)
    {
        for (int j=0;j<matrix.GetLength (1);j++)
        {
           matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            
        }
    
    }
    return matrix;
}

void PrintArray (double[,] matrix)
{
    for (int i=0;i<matrix.GetLength (0);i++)
    {
        for (int j=0;j<matrix.GetLength (1);j++)
        {
           Console.Write($"({matrix[i,j]})");
        }
        Console.WriteLine(" ");
    }
    
}