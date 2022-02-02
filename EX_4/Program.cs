// Найти максимальное из трех чисел

/*int num1 = new Random().Next(0,100);
int num2 = new Random().Next(0,100);
int num3 = new Random().Next(0,100);
*/

Console.WriteLine("Введите num1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите num2: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите num3: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

/*Console.WriteLine("num1 = " + num1);
Console.WriteLine("num2 = " + num2);
Console.WriteLine("num3 = " + num3);*/
Console.WriteLine("max = " + max);
