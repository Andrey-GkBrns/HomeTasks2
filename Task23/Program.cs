// Программа, которая выдаёт таблицу кубов от 1 до Z.
Console.Clear();
Console.Write("Введите число: ");
int Z = Convert.ToInt32(Console.ReadLine());
for (int X = 1; X <= Z; X++)
Console.Write($"{Math.Pow(X, 3)} ");