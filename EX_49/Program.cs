//  Показать двумерный массив размером m×n, заполненный вещественными числами.
void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            arr[i, j] = new Random().Next(0,100);
            double num = new Random().Next(0,100);
            num /= 100;
            arr[i, j] += num;
        }    
    }
}
void PrintArray(double[,] collection)
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


double[,] array = new double[5, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
