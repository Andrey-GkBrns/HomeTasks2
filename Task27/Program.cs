// Программа для посдчёта суммы чисел введённого числа.

Console.Clear();
Console.Write("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine()), count = 0;
while (X > 0)
{
count = count + X % 10;
X = X / 10;
}
Console.WriteLine($"Сумма чисел равна: {count}");