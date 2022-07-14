// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
Console.Write("Определите количество чисел для ввода - введите цифру ");

int elementCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementCount];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите любое целое число со знаком плюс или минус ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine($"{String.Join(", ", array)}");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
Console.WriteLine($"Количество чисел больше 0 = {count} ");
Console.WriteLine();
*/

Console.Write("Введите любые целые числа через запятую без пробелов и нажмите Enter:\t");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);


int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
Console.WriteLine($"{String.Join("; ", array)}");
Console.WriteLine($"Количество чисел больше 0 => {count} ");



// int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

// string inputString = "1111 2222 3333 4444";
// var ints = inputString.Split(' ').Select(Int32.Parse).ToArray();

// Console.WriteLine(ints);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// int b1 = 2;
// int k1 = 5;
// int b2 = 4;
// int k2 = 9;

// y = k1 * x + b1
// y = k2 * x + b2

/*
double[] LinearEquationSolution(int k1, int k2, int b1, int b2)
{
    int delta = k1 - k2;
    if (delta == 0) { throw new ArgumentException("у прямых не определена точка пересечения"); }
    int delta_x = -b1 * k2 + k1 * b2;
    int delta_y = b2 - b1;
    double x = Math.Round((double)delta_x / (double)delta, 1);
    double y = Math.Round((double)delta_y / (double)delta, 1);
    double[] solution = { x, y };
    return solution;
}

Console.WriteLine("\n" + "Задача 43");
Console.WriteLine("enter k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter b2");
int b2 = Convert.ToInt32(Console.ReadLine());

double[] solution = LinearEquationSolution(k1, k2, b1, b2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -->  ({String.Join(", ", solution)})");
*/

/*
Console.WriteLine("введите k1 и нажмите Enter");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k2 и нажмите Enter");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b1 и нажмите Enter");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b2 и нажмите Enter");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double auxiliary_b = b2 - b1;
double auxiliary_k = k1 - k2;
double pointX = auxiliary_b / auxiliary_k;
double pointY = pointX * k1 + b1;

Console.WriteLine(auxiliary_b);
Console.WriteLine(auxiliary_k);
Console.WriteLine();
Console.WriteLine($"Точка пересечения двух прямых ({pointX};{pointY})");
*/

/*
Console.WriteLine();
Console.WriteLine("Задача 43: Найти точку пересечения двух прямых");

void LinesCrossPoint(double k1, double k2, double b1, double b2)
{
    double auxiliary_b = b2 - b1;
    double auxiliary_k = k1 - k2;
    double pointX = auxiliary_b / auxiliary_k;
    double pointY = pointX * k1 + b1;
    Console.WriteLine($"Введенные значения: {k1}, {k2}, {b1}, {b2}");
    Console.WriteLine($"Точка пересечения двух прямых ({pointX}; {pointY})");
}

Console.WriteLine("введите k1 и нажмите Enter");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k2 и нажмите Enter");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b1 и нажмите Enter");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b2 и нажмите Enter");
int b2 = Convert.ToInt32(Console.ReadLine());

LinesCrossPoint(k1, k2, b1, b2);
*/








