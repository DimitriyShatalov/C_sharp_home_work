/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

//Решение, которое "не ругается" на преобразование литерала, допускающего значение NULL...
int number = Convert.ToInt32(Console.ReadLine());
String testNum = Convert.ToString(number);
Console.WriteLine("" + testNum [2]);

//А можно было и так...
// Console.WriteLine("Введите трехзначное число: "); // По желанию
/*
int number = Convert.ToInt32(Console.ReadLine()); // int number = new Random().Next(100,1000); - для разнообразия
Console.WriteLine(number);

int digitSecond = number / 10 % 10;

Console.WriteLine(digitSecond);
*/
