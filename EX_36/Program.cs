// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] numbers)
{
    int index = 0;
    while (index < numbers.Length)
    {
        numbers[index] = new Random().Next(100, 1000);
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
void CountEvenOddNumbers(int[] nums)
{
    int index = 0;
    int evenNums = 0;
    int oddNums = 0;
    while (index < nums.Length)
    {
        if (nums[index] % 2 == 0) evenNums += 1;
        else oddNums += 1;
        index++;
    }
    Console.WriteLine("Четных чисел: " + evenNums);
    Console.WriteLine("Нечетных чисел: " + oddNums);
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
CountEvenOddNumbers(array);