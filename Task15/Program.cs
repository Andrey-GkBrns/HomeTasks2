// Программа обозначающая по цифре день недели и проверяющая то, что является ли этот день выходным?
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
Console.Write("Понедельник");
else if (a == 2)
Console.Write("Вторник");
else if (a == 3)
Console.Write("Среда");
else if (a == 4)
Console.Write("Четверг");
else if (a == 5)
Console.Write("Пятница");
else if (a > 7)
Console.Write("Неверное число. Введите число согласно номеру дня недели. Это числа от 1 и до 7.");
else if (a == 6)
Console.WriteLine("Суббота");
if (a == 6)
Console.Write("И это выходной день");
else if (a == 7)
Console.WriteLine("Воскресенье");
if (a == 7)
Console.Write("И это выходной день");