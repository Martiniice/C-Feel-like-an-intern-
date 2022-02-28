// Задать двумерный массив следующим правилом: Aₘₙ = m+n.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            arr[i, j] = i + j;
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


int[,] array = new int[5, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
