// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

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
        result[i] = new Random().Next(-10, 10);
    }
    return result;
}

var newArray = FillArray(array);

PrintArray(newArray); // массив, заполненный случайными числами, 0-10

Console.WriteLine();

int SumNoEvenPos(int[] arr)
{
    int sumNoEvenI = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumNoEvenI += arr[i];
        }
    }
    return sumNoEvenI;
}

Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях в массиве: {SumNoEvenPos(newArray)}"); // сумма элементов, стоящих на нечётных позициях