// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());
int BOX = 1;
int i = 0;

while (i < B)
{
    BOX = BOX * A;
    i++;
}
Console.WriteLine(A + "^" + B + "=" + BOX);