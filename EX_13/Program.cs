// Выяснить, кратно ли число заданному, если нет, вывести остаток

int num1 = new Random().Next(1,1000);
Console.WriteLine("Задайте число:");
int num2 = int.Parse(Console.ReadLine());
int remainder = num1 % num2;
Console.WriteLine("Рандомное число = " + num1);

if (remainder == 0)
{
    Console.WriteLine("Рандомное число кратно Вашему, Ура!");
}
else
{
    Console.WriteLine(remainder);
}