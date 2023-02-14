// Программа для поиска натуральной степени при вводе соответствующих значений.

Console.Clear();
Console.Write("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int Y = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int Z = 1; Z <= Y; Z++)
count = count * X;
Console.Write($"Результат: {count}");