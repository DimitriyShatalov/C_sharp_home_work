//  Задача 2: Напишите программу, которая на вход принимает два числа
//  и выдаёт, какое число большее, а какое меньшее.

//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3


 Console.WriteLine("Введите первое число: ");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int numberB = Convert.ToInt32(Console.ReadLine());

    if (numberA > numberB)
    {
    Console.WriteLine ($"max = {numberA}  min = {numberB}");
    }
    else
    {
    Console.WriteLine ($"max = {numberB}  min = {numberA}");
    }



// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
System.Console.WriteLine("Ведите первое число: ");

int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");

int numberC = Convert.ToInt32(Console.ReadLine());

    if (numberA > numberB && numberA > numberC)
    {
        Console.WriteLine ("max = " + numberA);
    }
        if (numberB > numberA && numberB > numberC)
        {
            Console.WriteLine ("max = " + numberB);
        }
    else
    {
        Console.WriteLine ("max = " + numberC);
    }
*/

// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*
System.Console.WriteLine("Введите любое целое число: ");

int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

    if (result == 0)
    {
        System.Console.WriteLine("Число: " + number + " является четным ");
    }
    else
    {
        System.Console.WriteLine("число: " + number + " не является четным. Попробуйте ввести другое число ");
    }
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
