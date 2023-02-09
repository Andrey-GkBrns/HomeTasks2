// Программа для нахождения расстояния между точками в 3D пространстве.
Console.Clear();
Console.Write("Введите координату точки X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату точки Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double W = Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 2);
Console.Write($"Расстояние между точками будет равно: {W}");