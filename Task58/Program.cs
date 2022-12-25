// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];

FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();

FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();

if (matrix1.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

PrintMatrix(resultMatrix);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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
