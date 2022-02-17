// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,10);
}
void PrintArray (int[]collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write(collection[i] + " ");
}
int SummElementsArray (int[] numbers)
{
    int summ = 0;
    for (int i = 0; i < numbers.Length; i++) summ += numbers[i];
    return summ;
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(SummElementsArray(array));