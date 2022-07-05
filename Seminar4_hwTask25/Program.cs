// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(A,B));

// int A = new Random().Next(1,10);
// int B = new Random().Next(1,10);

// Console.WriteLine((A,B));
// Console.WriteLine(Math.Pow(A,B));