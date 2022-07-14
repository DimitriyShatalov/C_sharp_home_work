// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задача 41: Сколько чисел больше 0 ввёл пользователь?");

Console.WriteWriteLine("Введите любые целые числа через запятую без пробелов и нажмите Enter: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
Console.WriteLine($"{String.Join("; ", array)}");
Console.WriteLine($"Количество чисел больше 0 => {count} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задача 43: Найти точку пересечения двух прямых");

void LineIntersectionPoint(double k1, double k2, double b1, double b2)
{
    double pointX = ((b2 - b1) / (k1 - k2));
    double pointY = pointX * k1 + b1;
    Console.WriteLine($"Введенные значения: {k1}, {k2}, {b1}, {b2}");
    Console.WriteLine($"Точка пересечения двух прямых ({pointX}; {pointY})");
}

Console.WriteLine("введите значение k1 и нажмите Enter");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2 и нажмите Enter");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b1 и нажмите Enter");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2 и нажмите Enter");
int b2 = Convert.ToInt32(Console.ReadLine());

LineIntersectionPoint(k1, k2, b1, b2);
