// Задача 27: 
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите любое целое число ");
// int number = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(100,10000);
Console.WriteLine($"{number} ");

int result = 0;

for(int i = 1; number > 0; i++)
{
    result += number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма цифр в этом числе = {result} ");
/*
int number = new Random().Next(100,10000);
Console.WriteLine($"{number} ");

int result = 0;

    while (number > 0)
    {
    result += number % 10;

    number /= 10;
    }
    
Console.WriteLine($"Сумма цифр в этом числе = {result} ");
*/