// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];

void PrintArray(int[] arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

PrintArray(array); // массив создан и заполнен нулями

Console.WriteLine();

int[] FillArray(int[] arr)
{
    var result = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}

var newArray = FillArray(array);

PrintArray(newArray); // массив, заполненный случайными числами, 1-10

Console.WriteLine();

int SerchMax(int[] arr)
{
    int max = arr[0];
        for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
Console.WriteLine(SerchMax(newArray));

int SerchMin(int[] arr)
{
    int min = arr[0];;
        for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
Console.WriteLine(SerchMin(newArray));


Console.WriteLine($"Разницу между максимальным и минимальным элементом массива: {SerchMax(newArray)-SerchMin(newArray)}");