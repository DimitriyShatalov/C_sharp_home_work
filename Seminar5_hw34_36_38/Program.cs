// Внимание, внимание! 
// *Начиная с этого дз при оценке учитывается оформление
//  и названия переменных. Будьте внимательны)

// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
/*
int[] array = new int[8];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)

    array[i] = rand.Next(100, 999);

int sumIndex = 0;

for (int i = 0; i < array.Length; i++)

    if (array[i] % 2 == 0)
    {
        sumIndex += 1;
    }
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве {sumIndex}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] array = new int[8];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)

    array[i] = rand.Next(-10, 10);

int sumValue = 0;

for (int i = 1; i < array.Length; i++)

    if (i % 2 != 0)
    {
        sumValue += array[i];
    }

Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Сумма элементов на нечётных позициях = {sumValue}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] myArray = new double[8];
Random rand = new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = Math.Round((5 - rand.Next(11) + rand.NextDouble()), 3);
}

Console.WriteLine($"[{String.Join("; ", myArray)}]");
// double maxValue = myArray.Max();
// double minValue = myArray.Min();
// double result = maxValue - minValue;

Console.WriteLine($"Максимум = {myArray.Max()}");
Console.WriteLine($"Минимум = {myArray.Min()}");
Console.WriteLine($"Разница между макс и мин = {myArray.Max() - myArray.Min()}");
// Console.WriteLine($"Максимум = {Math.Round(myArray.Max(), 3)}");
// Console.WriteLine($"Минимум = {Math.Round(myArray.Min(), 3)}");
