// Найти сумму чисел от 1 до А
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int summ = 0;
while (num > 0)
{
    summ += num;
    num--;
}
Console.WriteLine(summ);