/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

// Console.WriteLine("Введите номер дня недели: ");

int dayNum = Convert.ToInt32(Console.ReadLine());

string response = "нет";

if (dayNum > 5 && dayNum < 8) response = "да";
{
    Console.WriteLine($"{dayNum} -> {response}");
}

// Console.WriteLine("Введите номер дня недели: ");
/*
int dayNum = Convert.ToInt32(Console.ReadLine());

if (dayNum > 5 && dayNum < 8)

    {
        Console.WriteLine ("Да. Сегодня выходной! ");
    }

    else
    {
        Console.WriteLine ("Нет ");
    }
*/

