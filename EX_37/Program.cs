// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,150);
}
void PrintArray (int[]collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write(collection[i] + " ");
}
int HowManySimilarNumbers (int[] numbers, int min, int max)
{
    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > min && numbers[i] < max)
        counter++;
    }
    return counter;
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(HowManySimilarNumbers(array, 9, 100));