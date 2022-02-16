// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void FillArray(int[] numbers)
{
    int index = 0;
    while (index < numbers.Length)
    {
        numbers[index] = new Random().Next(1, 100);
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
int MaxElementArray(int[] elements)
{
    int max = elements[0];
    int index = 1;
    while (index < elements.Length)
    {
        if (elements[index] > max) max = elements[index];
        index++;
    }
    return max;
}
int MinElementArray(int[] elementes)
{
    int min = elementes[0];
    int index = 1;
    while (index < elementes.Length)
    {
        if (elementes[index] < min) min = elementes[index];
        index++;
    }
    return min;
}

int[] array = new int[7];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(MaxElementArray(array));
System.Console.WriteLine(MinElementArray(array));
System.Console.WriteLine(MaxElementArray(array) - MinElementArray(array));