// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Convert.ToInt32(Console.ReadLine());
string testNum = Convert.ToString(number);


    if(testNum[0] == testNum[4] || testNum[1] == testNum[3])
    Console.WriteLine("-> да ");
    else
    {
        Console.WriteLine("-> нет ");
    }
