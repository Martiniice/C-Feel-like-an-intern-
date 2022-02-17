// Задать массив из 8 элементов и вывести их на экран
void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1,10);
}
void PrintArray (int[]collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write(collection[i] + " ");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);