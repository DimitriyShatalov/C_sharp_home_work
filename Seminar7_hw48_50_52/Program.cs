
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] matrix = new double[3,4];

Random rand = new Random();
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j< matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round(rand.Next(-20, 20) + rand.NextDouble(), 2);       //matrix[i,j] = Math.Round(new Random().NextDouble()*100);
                                                                                   //matrix[i,j] = Math.Round((5 - rand.Next(11) + rand.NextDouble()), 3)
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4     17 -> такого числа в массиве нет

int[,] matrix = 
{   {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}, };

int element = new Random().Next(17,21);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(matrix[i, j]!= element)
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Числа {element} в этом массиве нет");


// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix =
{   {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}, };

int rowLength = matrix.GetLength(0);
int columnLength = matrix.GetLength(1);
double[] arrayAverage = new double[columnLength];
double sum = 0;

Console.WriteLine("Matrix:");
for (int i = 0; i < rowLength; i++)
{
    for (int j = 0; j < columnLength; j++)
    {
        Console.Write(matrix[i, j] + " "); 
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < columnLength; i++)
{
    for (int j = 0; j < rowLength; j++)
    {
        sum = sum + matrix[j, i];  
    }
    arrayAverage[i] = Math.Round((sum / rowLength), 2); 
    sum = 0; 
}

Console.WriteLine("Average sums:");
for (int i = 0; i < columnLength; i++)
{
    Console.Write(arrayAverage[i] + " "); 
}
Console.WriteLine();




