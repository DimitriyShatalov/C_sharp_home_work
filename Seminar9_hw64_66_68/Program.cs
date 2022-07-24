
// На 5 нужно сделать 2 задачки, обязательно сделать 68 (конкретно на 5)

// Задача 64: 
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(M, N));

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.ReadKey();


// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numM = Convert.ToInt32(Console.ReadLine());
int numN = Convert.ToInt32(Console.ReadLine());
int m = numM;
int n = numN;           // Без переменных m и n код не работал. ???

int GaussSumNumbers(int n)
{
    if (n == m) return m;
    return n + GaussSumNumbers(n - 1);
}
Console.WriteLine($"Сумма чисел от {m} до {n} = {GaussSumNumbers(n)}");
Console.ReadKey();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

//Функция Аккермана: A(n,m) = {m+1 при n = 0; A(n-1),1 при n!=0, m = 0; A(n-1, A(n,m - 1)) при n>0, m>0

int argM = Convert.ToInt32(Console.ReadLine());
int argN = Convert.ToInt32(Console.ReadLine());

int n = argN;
int m = argM;
int AckermannFunc(int n, int m)
{
if (n == 0) return m + 1;
if (m == 0) return AckermannFunc(n - 1, 1);

return AckermannFunc(n - 1, AckermannFunc(n, m - 1));
}
Console.WriteLine($"Функция Аккермана A({n},{m})= {AckermannFunc(n,m)}");
Console.ReadKey();
