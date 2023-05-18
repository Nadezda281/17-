//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//Решение:

int[,] arr = new int[3, 3];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
    }
}

// Вывод двумерного массива
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();


for (int j = 0; j < arr.GetLength(1); j++)
{
    double numbers = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        numbers = numbers + arr[i, j];
    }
    numbers = numbers / 3;
    numbers = Math.Round(numbers, 1);
    Console.Write($"Cреднее арифметическое элементов: {numbers}");
    Console.WriteLine();
}

