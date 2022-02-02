// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());
bool resalt1 = num > 99;
bool resalt2 = num < 1000;

if (resalt1 == resalt2)
    {
        Console.WriteLine(num % 10);
    }

else Console.WriteLine("Ошибка: Введено не ТРЕХЗНАЧНОЕ число!");
