// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите число №1:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2:");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine(num1 + " = " + num2);
}
else 
{
    if (num1 > num2)
    {
        Console.WriteLine("more = " + num1);
        Console.WriteLine("less = " + num2);
    }
    else
    {
        Console.WriteLine("more = " + num2);
        Console.WriteLine("less = " + num1);
    }
}