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
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}

var newArray = FillArray(array);

PrintArray(newArray); // массив, заполненный случайными числами, от -100 до 100

Console.WriteLine();

int Difference(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Минимальный элемент {min}");
    Console.WriteLine($"Максимальный элемент {max}");
    int dif = max - min;
    return dif;
}
Console.WriteLine(Difference(newArray));