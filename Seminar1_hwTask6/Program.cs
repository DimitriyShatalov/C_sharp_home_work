// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


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

