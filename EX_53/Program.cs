// В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
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
void SearchNum(int[,] aray, int num)
{   
    int count = 0;
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++) 
        {
            if (aray[i, j] == num)
            {   
                System.Console.WriteLine($"число {num} встречается в массиве на позиции в строке {i + 1}, в столбце {j + 1}");
                count++;
            }
        }
    }        
    if (count == 0) System.Console.WriteLine("Указанное число не встречается в массиве");
}


int[,] array = new int[2, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Введите число для поиска в массиве:");
int number = int.Parse(Console.ReadLine());
SearchNum(array, number);
