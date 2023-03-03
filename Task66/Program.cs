// Программа (рекурсия) для нахождения суммы натуральных чисел в указанном промежутке.

string f(int Z, int Y)
{if (Z == Y)
return $"{Y}";
return f(Z, Y - 1) + $", {Y}";}

int Sum(int Z, int Y)
{int res = Z;
if (Z == Y)
return 0;
else 
{Z++;
res = Z + Sum(Z, Y);
return res;}}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int Z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(Y, Z));
Console.WriteLine(Sum(Y, Z));