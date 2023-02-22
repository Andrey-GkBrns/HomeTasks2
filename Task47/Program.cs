/* Программа для заполнения заданного двумерного массива случайными
вещественными числами. */

void InputMatrix(double[,] matrix)
{for (int X = 0; X < matrix.GetLength(0); X++)
{for (int Y = 0; Y < matrix.GetLength(1); Y++)
{matrix[X, Y] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 2);
Console.Write($"{matrix[X, Y]} \t");}
Console.WriteLine();}}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(Z => int.Parse(Z)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);