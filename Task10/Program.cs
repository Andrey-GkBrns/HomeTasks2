// Программа для вывода второй цифры в трёхзначных числах.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100;
int c = b / 10;
Console.WriteLine($"Вторая цифра здесь: {c}");