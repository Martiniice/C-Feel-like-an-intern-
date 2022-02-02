// По заданному номеру дня недели вывести его название
string[] array = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
Console.WriteLine("Напишите номер дня: ");

int num = int.Parse(Console.ReadLine());

Console.WriteLine(array[num - 1]);
