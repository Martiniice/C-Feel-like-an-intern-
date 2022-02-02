// Показать четные числа от 1 до N

Console.WriteLine("Введите до какого числа ищем четные числа:");
int lastNUM  = int.Parse(Console.ReadLine());
int num = 0;

while (num < lastNUM - 1)
{
    num = num + 2;
    Console.Write(num + ",");
}