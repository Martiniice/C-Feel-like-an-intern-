// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти (от 1 до 4):");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1) Console.WriteLine("X: (0;+inf); Y: (0;+inf)");
else if (quarter == 2) Console.WriteLine("X: (-inf; 0); Y: (0;+inf)"); 
else if (quarter == 3) Console.WriteLine("X: (-inf; 0); Y: (0;-inf)"); 
else if (quarter == 4) Console.WriteLine("X: (0;inf); Y: (0;-inf)"); 