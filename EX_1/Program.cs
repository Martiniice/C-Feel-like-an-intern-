// По двум заданным числам проверять является ли первое квадратом второго

int num1 = new Random().Next(1,10);
int num2 = new Random().Next(1,82);

if (num1 * num1 == num2)
{
    Console.WriteLine("num1 : " + num1);
    Console.WriteLine("num2 : " + num2);
    Console.WriteLine("True : num1^2 = num2 = " + num2);
}
else 
{
    Console.WriteLine("num1 : " + num1);
    Console.WriteLine("num2 : " + num2);
    Console.WriteLine("False : num1^2 = " + num1 * num1);
}