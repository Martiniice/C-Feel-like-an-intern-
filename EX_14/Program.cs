// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число:");
string introduced = Console.ReadLine();
int counter = introduced.Length;
int size = 3;
int factor = 1;
while (size < counter)
{
   factor = factor * 10;
   size++;
}


if (counter < size)
{
    Console.WriteLine("Ошибка: Число не состоит из " + size + " цифр");
}
else
{
    Console.WriteLine(int.Parse(introduced) / factor % 10);
}