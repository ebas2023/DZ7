/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

Console.WriteLine("Введите количество элементов двумерного массива m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество элементов двумерного массива n:");
int n = int.Parse(Console.ReadLine()!);

int [,] matrix =GetArray(m,n);
PrintArray(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sumsrzn= 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumsrzn =(sumsrzn + matrix[i, j]);
    }
    sumsrzn = sumsrzn / n;

    Console.Write($"{Math.Round(sumsrzn,2)} ");
}


int [,] GetArray(int m, int n)
{
    int [,] matrix=new int[m,n];
    for (int i=0;i<matrix.GetLength (0);i++)
    {
        for (int j=0;j<matrix.GetLength (1);j++)
        {
           matrix[i, j] = new Random().Next(0, 10);
                   }
    
    }
    return matrix;
}

void PrintArray (int[,] matrix)
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
