// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Задайте последнее число возводимое в куб: ");
int number = int.Parse(Console.ReadLine());
int i = 2;
while (i < number+1)
{
    if ((Math.Pow(i,3)) % 2 == 0)
    {
        Console.WriteLine(i + "^3="+ Math.Pow(i,3));
    }
    i++;
}