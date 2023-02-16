// Программа для определения суммы чисел на нечётных позициях массива, который выводит числа в случайном порядке.

void EnterArr(int[] arr)
{for (int Y = 0; Y < arr.Length; Y++)
arr[Y] = new Random().Next(1, 100);} // [1, 99]

int SumUneven(int[] arr)
{int sum = 0;
for (int i = 1; i < arr.Length; i+=2)
sum = sum + arr[i];
return sum;}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int X = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[X];
EnterArr(arr);
Console.WriteLine($"Случайный массив: [{string.Join(", ", arr)}]");
Console.Write($"Сумма чисел на нечётных позициях массива = {SumUneven(arr)}");