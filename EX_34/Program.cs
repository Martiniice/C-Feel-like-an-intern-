// Написать программу замену элементов массива на противоположные
void FillArray(int[] numbers)
{
    int index = 0;
    while (index < numbers.Length)
    {
        numbers[index]= new Random().Next(-9,10);
        index++;
    }
}

void PrintArray(int[] nums)
{
    int index = 0;
    while (index < nums.Length)
    {
        Console.Write(nums[index] + " ");
        index++;
    }
}

void OppositeArray(int[] numbs)
{
    int index = 0;
    while (index < numbs.Length)
    {
        numbs[index] *= -1;
        index++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
OppositeArray(array);
PrintArray(array);