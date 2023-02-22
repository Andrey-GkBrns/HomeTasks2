/* Программа для подсчёта среднего арифметического элементов, находящихся
в каждом столбце двумерного массива. */

void InputMatrix(int[,] matrix)
{for(int X = 0; X < matrix.GetLength(0); X++)
{for(int Y = 0; Y < matrix.GetLength(1); Y++)
{matrix[X, Y] = new Random().Next(1, 10);
Console.Write($"{matrix[X, Y]} \t");}
Console.WriteLine();}}

void OutputMatrix(int[,] matrix)
{for(int Y = 0; Y < matrix.GetLength(1); Y++)
{double sum = 0;
for(int X = 0; X < matrix.GetLength(0); X++)
{sum += matrix[X, Y];}
Console.WriteLine($"Среднее арифметическое в {Y + 1}-м столбце = {Math.Round(sum / matrix.GetLength(0), 2)}");}}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(Z => int.Parse(Z)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
OutputMatrix(matrix);