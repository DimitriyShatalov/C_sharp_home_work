// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите любое целое число ");
int count = 0;
int limit = Convert.ToInt32(Console.ReadLine());


     while(count < limit - 1)
    {
        count = count + 2;
        Console.WriteLine(count);
    }
    