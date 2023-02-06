// Программа по поиску второго по величине из заданных чисел. Остановкой работы является ввод нуля.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max2 = 0;
while (a != 0)
{if (a > max);
max2 = max;
max = a;
a = Convert.ToInt32(Console.ReadLine());}
Console.Write($"Второе по величине из введённых чисел - будет: {max2}");