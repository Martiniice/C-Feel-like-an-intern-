// Показать числа от -N до N
Console.WriteLine("Введите min значение N:");
int minN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите max значение N:");
int maxN = int.Parse(Console.ReadLine());


int nextN = minN;

while (nextN <= maxN)
{
    Console.Write(nextN + ",");
    nextN++;
}

