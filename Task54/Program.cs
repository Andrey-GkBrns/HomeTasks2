// Программа по упорядочиванию элементов в каждой строке - в двумерном массиве.

void InputMatrix(int[,] matrix)
{for (int X = 0; X < matrix.GetLength(0); X++)
{for (int Y = 0; Y < matrix.GetLength(1); Y++)
matrix[X, Y] = new Random().Next(1, 16);}}

void PrintMatrix(int[,] matrix)
{for (int X = 0; X < matrix.GetLength(0); X++)
{for (int Y = 0; Y < matrix.GetLength(1); Y++)
Console.Write($"{matrix[X, Y]} \t");
Console.WriteLine();}}

void ReleaseMatrix(int[,] matrix)
{for (int X = 0; X < matrix.GetLength(0); X++)
{for (int Y = 0; Y < matrix.GetLength(1); Y++)
{for (int Z = 0; Z < matrix.GetLength(1) - 1; Z++)
{if (matrix[X, Z] < matrix[X, Z + 1])
{int temp = matrix[X, Z + 1];
matrix[X, Z + 1] = matrix[X, Z];
matrix[X, Z] = temp;}}}}}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(W => int.Parse(W)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный двумерный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
Console.WriteLine("Конечный двумерный массив: ");
PrintMatrix(matrix);