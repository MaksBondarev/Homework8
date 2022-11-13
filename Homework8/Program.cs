// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ZamenaArray(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] < array[i, x + 1])
                {
                    count = 0;
                    count = array[i, x];
                    array[i, x] = array[i, x + 1];
                    array[i, x + 1] = count;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количествщ строк и столбцов ");
string[] arr = Console.ReadLine().Split(' ');
int n = int.Parse(arr[0]);
int m = int.Parse(arr[1]);
int[,] array = new int[n, m];
Console.WriteLine("Begin: ");
InputArray(array);
Console.WriteLine("Rezalt: ");
ZamenaArray(array);
PrintArray(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SummArray(int[,] array)
{
    int minA = 0;
    int minSumm = 0;
    int sumB = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minA = minA + array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumB = sumB + array[i, j];
        if (sumB < minA)
        {
            minA = sumB;
            minSumm = i;
        }
        sumB = 0;
    }
    Console.Write($"{minSumm + 1} строка");
}

Console.Clear();
Console.Write("Введите количествщ строк и столбцов ");
string[] arr = Console.ReadLine().Split(' ');
int n = int.Parse(arr[0]);
int m = int.Parse(arr[1]);
int[,] array = new int[n, m];
InputArray(array);
Console.WriteLine();
SummArray(array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ComposArray(int[,] array1, int[,] array2)
{
    int[,] RezaltArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            RezaltArray[i, j] = array1[i, j] * array2[i, j];
            Console.Write(RezaltArray[i, j] + " \t");
        }
        Console.WriteLine();
    }

}

Console.Clear();
Console.Write("Введите количествщ строк и столбцов ");
string[] arr = Console.ReadLine().Split(' ');
int n = int.Parse(arr[0]);
int m = int.Parse(arr[1]);
int[,] array1 = new int[n, m];
int[,] array2 = new int[n, m];
Console.WriteLine("Матрица 1: ");
InputArray(array1);
Console.WriteLine("Матрица 2: ");
InputArray(array2);
Console.WriteLine("Rezalt: ");
ComposArray(array1, array2);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void InputArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array[i, j, k] = new Random().Next(1, 20);
                Console.WriteLine(array[i, j, k] + " (" + i + ", " + j + ", " + k + ") ");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите координаты х, y, z: ");
string[] arr = Console.ReadLine().Split(' ');
int x = int.Parse(arr[0]);
int y = int.Parse(arr[1]);
int z = int.Parse(arr[1]);
int[,,] array = new int[x, y, z];
Console.WriteLine();
InputArray(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void InputArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");

        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите координаты Х, Y  ");
string[] arr = Console.ReadLine().Split(' ');
int x = int.Parse(arr[0]);
int y = int.Parse(arr[1]);
int[,] array = new int[x, y];
Console.WriteLine();
InputArray(array);

