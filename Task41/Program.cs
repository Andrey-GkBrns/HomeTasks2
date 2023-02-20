// Программа для подсчёта количества введённых чисел, которые будут больше нуля.

Console.Clear();
Console.Write("Укажите, сколько чисел Вы будете далее вводить?: ");
int X = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < X; i++)
{Console.Write("Введите число: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (Y > 0) count++;}
Console.Write($"Количество чисел больше нуля: {count}");