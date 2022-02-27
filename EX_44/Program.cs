// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы ответ (x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1)

System.Console.WriteLine("уравнение двух прямых y = k1 * x + b1, y = k2 * x + b2");
System.Console.WriteLine("Введите k1:");
int k1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите b1:");
int b1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите k2:");
int k2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите b2:");
int b2 = int.Parse(Console.ReadLine());
double X = (b2-b1)/(k1-k2);
double Y = k1*(b2-b1)/((k1-k2)+b1);

System.Console.WriteLine($"Точка пересечения X:{X} Y:{Y}");
