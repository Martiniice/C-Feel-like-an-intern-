// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(1,10);
}
void PrintArray (int[]collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write(collection[i] + " ");
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int index = 0;
int indexLast = array.Length - 1;
int counter = 1;
while (index < indexLast)
{
    System.Console.WriteLine("Multiplication{0}: " + array[index] * array[indexLast],counter);
    index++;
    indexLast--;
    counter++;
}