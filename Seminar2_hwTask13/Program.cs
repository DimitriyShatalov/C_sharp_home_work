/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number = Convert.ToInt32(Console.ReadLine());
String testNum = Convert.ToString(number);

int i = testNum.Length;

    if(i <= 2)
    {
    Console.WriteLine("Третьей цифры нет ");
    }
    else
        Console.WriteLine("" + testNum [2]);
