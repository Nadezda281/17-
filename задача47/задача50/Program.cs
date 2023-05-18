//Задача 50. Напишите программу, которая на вход принимает число, 
//и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет
//Решение:

Console.Write("Введите число: ");
int rows = int.Parse(Console.ReadLine());

int x = rows;
int y = rows;





int[,] arr = new int[6, 5];
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


// нахождение позиции

if (x > arr.GetLength(0) || y > arr.GetLength(1))
{
    Console.WriteLine("такого элемента нет");

}

else
{

    Console.WriteLine($" элемент {rows} есть в масиве ");
}



int ind1 = 0,  ind2 = 1;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (rows == arr[i, j])
           {
             ind1 = i;
              ind2 = j;
Console.WriteLine($" элемент массива = {rows} с индексом [{ind1},{ind2}]");
    }

     
}
}

  


    