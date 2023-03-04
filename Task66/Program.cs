// Программа (рекурсия) для нахождения суммы натуральных чисел в указанном промежутке.

string X(int Y, int Z)
{if (Y == Z)
return $"{Z}";
return X(Y, Z - 1) + $", {Z}";}

int Sum(int Y, int Z)
{int Res = Y;
if (Z < Y)
return 0;
else 
{Y++;
Res = Y + (Sum(Y, Z) - 1);
return Res;}}

Console.Clear();
Console.Write("Введите 1-ое число: ");
int Z = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(X(Z, Y));
Console.WriteLine(Sum(Z, Y));