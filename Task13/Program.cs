// Программа для вывода третьей цифры в ведённом числе или сообщении об её отсутствии.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 99)
Console.WriteLine($"В данном числе - третьей цифры нет...");
else
{while (a >= 1000)
{a = a / 10;}
int b = a % 10;
Console.WriteLine($"В этом числе третьей цифрой будет: {b}");};