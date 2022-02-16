// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
for (sum = 0; number > 0; number /= 10) 
{
    sum += number % 10;
}
Console.Write("Сумма цифр вашего числа = " + sum);