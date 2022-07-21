// На оценку "5" нужно сделать минимум 4 задачи

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] matrix = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

int rowLength = matrix.GetLength(0);
int columnLength = matrix.GetLength(1);
int newVar = 0;

System.Console.WriteLine("Array before sort:");
for (int i = 0; i < rowLength; i++)
{
    for (int j = 0; j < columnLength; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < rowLength; i++)
{
    for (int k = 0; k < columnLength - 1; k++)
    {
        for (int j = 0; j < columnLength - 1; j++)
        {
            if (matrix[i, j] > matrix[i, j + 1])
            {
                newVar = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = newVar;
            }
        }
    }
}

Console.WriteLine("Array after sort:");
for (int i = 0; i < rowLength; i++)
{
    for (int j = 0; j < columnLength; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = {{1,4,7,3}, {5,9,2,3}, {8,4,2,4}, {8,4,2,6}};
int sum = 0;
int[] array = new int[4];
int min = int.MaxValue;
int idMin = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            array[i] = sum;
        }
            if (sum < min)
            {
            min = sum; idMin = i;
            }
            Console.WriteLine("Сумма " + (i+1) + " строки равна " + sum);
            sum = 0;  
    }
}
Console.WriteLine("Строка с наименьшей суммой элементов = " + min + ", под индексом: " + idMin);
Console.ReadKey();

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2  и // 1 5 8 5
// 5 9 2 3    // 4 9 4 2
// 8 4 2 4    // 7 2 2 6
// 5 2 6 7    // 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] matrixA =
{   {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7} };

int[,] matrixB =
{   {1,5,8,5},
    {4,9,4,2},
    {7,2,2,6},
    {2,3,4,7} };

int rowA = matrixA.GetLength(0);
int columnA = matrixA.GetLength(1);
int rowB = matrixA.GetLength(0);
int columnB = matrixA.GetLength(1);

Console.WriteLine("MatrixA: ");
for (int i = 0; i < rowA; i++)
{
    for (int j = 0; j < columnA; j++)
    {
        Console.Write(matrixA[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("MatrixB: ");
for (int i = 0; i < rowB; i++)
{
    for (int j = 0; j < columnB; j++)
    {
        Console.Write(matrixB[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

int temp = 0;
int[,] matrixMultyple = new int[rowA, columnB];

Console.WriteLine("MatrixMultyple (MatrixA * MatrixB): ");
for (int i = 0; i < rowA; i++)
{
    for (int j = 0; j < columnB; j++)
    {
        temp = 0;
        temp+= matrixA[i,j] * matrixB[i,j];
        matrixMultyple[i,j] = temp;
        
        Console.Write(matrixMultyple[i, j] + "\t");
    }
    Console.WriteLine();
}

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] matrix = new int [2,2,2];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k] = new Random().Next(10,100);
            Console.Write($"{matrix[i,j,k]} ({i},{j},{k})" + "\t");
        }
    Console.WriteLine();
    }
}

//для 62 задачи пока не созрел :'( 	:-$










