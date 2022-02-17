// Определить, присутствует ли в заданном массиве, некоторое число
void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,10);
}
void PrintArray (int[]collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write(collection[i] + " ");
}
bool CheckingNumberInArray (int[] numbers, int number)
{
    bool result = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == number)
        {
            result = true;
            break;
        }
        else result = false;
    }
    return result;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine(CheckingNumberInArray(array, num));