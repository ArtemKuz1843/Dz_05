// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

var newArray = FillArray(array);

PrintArray(newArray); // массив заполненный случайными положительными трёхзначными числами

Console.WriteLine();

int Quantity(int[] arr)
{
    int pol = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 )
        {
            pol += 1;
        }
    }
    return pol;
}

Console.WriteLine($"Количество положительных чисел в массиве: {Quantity(newArray)}"); // количество чётных чисел в массиве


