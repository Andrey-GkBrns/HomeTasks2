// Прогорамма для определения количества чётных чисел в случайном массиве.

void EnterArr(int[] arr)
{for (int Y = 0; Y < arr.Length; Y++)
arr[Y] = new Random().Next(100, 1000);}

int EvenNumbers(int[] arr)
{int count = 0;
foreach(int number in arr)
{if (number % 2 == 0)
count++;}
return count;}

//Console.Clear();
Console.Write("Введите количество элементов массива: ");
int X = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[X];
EnterArr(arr);
Console.WriteLine($"Случайный массив: [{string.Join(", ", arr)}]");
Console.Write($"Количество чётных чисел в массиве = {EvenNumbers(arr)}");