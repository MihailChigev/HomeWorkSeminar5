// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

System.Console.WriteLine("задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int leftRange = 1;
int rightRange = 100;
int[] array = new int[size];


int[] FillArrayWithRandomNumber(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

int DiffMaxMin(int[] arr1)
{
    int maxPos = 0;
    int minPos = 0;

    for (int i = 1; i < arr1.Length; i++)
    {
        if (arr1[i] > arr1[maxPos])
        {
            maxPos = i;
        }
        if (arr1[i] < arr1[minPos])
        {
            minPos = i;
        }
    }
    int diff = arr1[maxPos] - arr1[minPos];
    return diff;
}


array = FillArrayWithRandomNumber(size, leftRange, rightRange);
Console.Write("[" + string.Join(", ", array) + "]");



int diff = DiffMaxMin(array);
System.Console.WriteLine("-> " +diff);