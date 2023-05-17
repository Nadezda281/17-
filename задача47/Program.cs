//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

//m = 3, n = 4.

//0,5 7,0 -2,0 -0,2

//1,0 -3,3 8,0 -9,9

//8,0 7,8 -7,1 9,0
//Решение:

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        double number = new Random().Next(-10, 10) + new Random().NextDouble();
        array[i,j] =  Math.Round(number, 1);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

