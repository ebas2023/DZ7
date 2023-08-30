/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
позиция i = 4, j = 2 -> такой позиции нет
позиция i = 1, j = 0 -> 5*/

Console.WriteLine("Введите количество элементов двумерного массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов двумерного массива n:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер элемента массива x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента массива y:");
int y = Convert.ToInt32(Console.ReadLine());;

double [,] matrix =GetArray(m,n);
PrintArray(matrix);
if (x>matrix.GetLength (0) || y>matrix.GetLength (1))
{
Console.WriteLine("Такой позиции нет");
}
else 
Console.Write($"({matrix[x,y]})");
{

}

double [,] GetArray(int m, int n)
{
    double [,] matrix=new double[m,n];
    for (int i=0;i<matrix.GetLength (0);i++)
    {
        for (int j=0;j<matrix.GetLength (1);j++)
        {
           matrix[i, j] = new Random().Next(-10, 10);
            
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