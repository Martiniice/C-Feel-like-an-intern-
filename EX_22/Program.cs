// Найти расстояние между точками в пространстве 2D/3D
Console.Write("Введите цифру равную мерности пространства(2 или 3): ");
int space = int.Parse(Console.ReadLine());
if (space == 2)
{
    Console.Write("Задайте точку X1: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку Y1: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку X2: ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку Y2: ");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Расстояние между заданными точками = " + Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)),3));
}
else if (space == 3)
{
    Console.Write("Задайте точку X1: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку Y1: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку Z1: ");
    int z1 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку X2: ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку Y2: ");
    int y2 = int.Parse(Console.ReadLine());
    Console.Write("Задайте точку Z2: ");
    int z2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Расстояние между заданными точками = " + Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),3));
}
else Console.Write("Выбрана неправильная мерность пространства!");