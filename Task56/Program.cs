// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей 
// суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

var arr = FillMatrix(4, 4);
PrintMatrix(arr);
Console.WriteLine();
NumberSmallSumRow(arr);

void NumberSmallSumRow(int[,] array)
{
    int smallRow = 0;
    int smallSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        smallRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < smallRow)
        {
            smallRow = sumRow;
            smallSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{smallSumRow + 1} строка");
}

int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       // Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}
