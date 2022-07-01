/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(100,1000);
Console.WriteLine(number);

int digitSecond = number / 10 % 10;

Console.WriteLine(digitSecond);

//int number = Convert.ToInt32(Console.ReadLine());
//String testNum = Convert.ToString(number);
//Console.WriteLine("" + testNum [2]);