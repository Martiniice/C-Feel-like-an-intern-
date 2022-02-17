// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int total = 1;
while (num > 1)
{
    total *= num;
    num--;
}
Console.WriteLine(total);