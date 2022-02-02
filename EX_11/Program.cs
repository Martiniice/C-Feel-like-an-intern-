// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int num = new Random().Next(10,100);
int num1 = num / 10;
int num2 = num % 10;

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else 
{
    Console.WriteLine(num2);
}

//Console.WriteLine(num);