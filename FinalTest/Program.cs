
string[] arrString = { "123", "1234", "12345", "one", "seven", "ok", ":)" };
int newArrayLength = 0;

Console.WriteLine("Изначально заданный массив: ");
Console.WriteLine($"{String.Join("; ",arrString )}");

for (int i = 0; i < arrString.Length; i++)
{
    if (arrString[i].Length <= 3)
    {
        newArrayLength++;
    }
}

Console.WriteLine();
Console.WriteLine("Финальный массив с элементами, у которых три и меньше символов: ");

string[] newArray = new string[newArrayLength];
int k = 0;
for (int i = 0; i < arrString.Length; i++)
{
    if (arrString[i].Length <= 3)
    {
        newArray[k] = arrString[i];
        //Console.Write($"{newArray[k]}" + " ");
        k++;
    }
}
Console.WriteLine($"{String.Join("; ",newArray )}");
Console.ReadKey();

