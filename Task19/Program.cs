// Программа для определения пятизначного числа на палиндром.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10000;
int c = a % 10;
int d = a / 1000;
int e = a % 100;
if (a < 10000 || a > 99999)
Console.Write("Неверное число. Необходимо ввести число из пяти цифр!");
else if (b == c || d == e)
Console.WriteLine("Это число - палиндром!");
else
Console.WriteLine("Это число не является палиндромом...");