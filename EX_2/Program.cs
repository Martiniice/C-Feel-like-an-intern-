// Даны два числа. Показать большее и меньшее число

int num1 = new Random().Next(1,100);
int num2 = new Random().Next(1,100);

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