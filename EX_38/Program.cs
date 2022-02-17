// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] numbers)
{
    int index = 0;
    while (index < numbers.Length)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] numbs)
{
    int index = 0;
    while (index < numbs.Length)
    {
        Console.Write(numbs[index] + " ");
        index++;
    }
}
void SummNumbersOddIndex(int[] nums)
{
    int index = 0;
    int summ = 0;
    while (index < nums.Length)
    {
        summ += nums[index];
        index += 2;
    }
    System.Console.WriteLine("Сумма чисел стоящих на нечетной позиции равна: " + summ);
}

int[] array = new int[14];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SummNumbersOddIndex(array);