Console.Write("Введите b1: ");
double b1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt16(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами Х: {x} , Y: {y}");