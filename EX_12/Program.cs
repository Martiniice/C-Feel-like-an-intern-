// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());
bool resalt1 = num > 99;
bool resalt2 = num < 1000;

if (resalt1 == resalt2)
    {
        int num1 = num / 100;
        int num2 = num % 10;
        num = num1 * 10 + num2;
        Console.WriteLine(num);
    }

else Console.WriteLine("Ошибка: Введено не ТРЕХЗНАЧНОЕ число!");

