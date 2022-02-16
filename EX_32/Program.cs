// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void FillArray(int[] numbers)
{
    int index = 0;
    while (index < numbers.Length)
    {
        numbers[index]= new Random().Next(0,2);
        index++;
    }
}

void PrintArray(int[] nums)
{
    int index = 0;
    while (index < nums.Length)
    {
        System.Console.Write(nums[index]);
        index++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);