// Определить сколько чисел больше 0 введено с клавиатуры

System.Console.Write("Введите числа через пробел: ");
string nums = Console.ReadLine();
var data = nums.Split(" ")
            .Select(item => item.Split(" "))
            .Select(e => int.Parse(e[0]))         
            .ToArray();
int count = 0;
for (int i = 0; i < data.Length; i++)
{
    if (data[i] > 0) count++;
}
System.Console.WriteLine($"Введено {count} чисел больше 0");