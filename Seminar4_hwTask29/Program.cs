// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int[]array = new int[8];

void FillArray(int[] collection)
{
    int length = array.Length;
    int index = 0;
     while(index < length)
    {
        array[index] = new Random().Next(1,9);

        index++;
    }
}
FillArray(array);

Console.WriteLine($"[{String.Join("; ",array )}]");

// int[] array = GetNumberArray(8);
// Console.WriteLine($"[{String.Join("; ",array )}]");

// int[] GetNumberArray(int size)
// {
//     int[]resultArray = new int[size];
//     for(int i = 0; i<size; i++)
//     {
//         resultArray[i] = new Random().Next(9);
//     }
//     return resultArray;
// }
