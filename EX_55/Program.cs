// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            arr[i, j] = new Random().Next(0,10);
        }    
    }
}
void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) 
        {
            Console.Write(collection[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


int[,] array = new int[3, 5];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int summ = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++) 
    {
        summ += array[j, i];
    }
    System.Console.WriteLine($"Сумма столбца {i + 1} = {summ}");
    summ = 0;
}
