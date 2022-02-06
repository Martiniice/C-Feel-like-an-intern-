// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num > 0 && num < 8) 
{
    if (num < 6)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Ура! Выходной");
    }
}
else Console.WriteLine("В неделе 7 дней!");