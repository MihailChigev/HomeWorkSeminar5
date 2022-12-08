// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

System.Console.WriteLine("задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int leftRange = 100;
int rightRange = 1000;
int count = 0;
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

array = FillArrayWithRandomNumber(size, leftRange, rightRange);
Console.Write("[" + string.Join(", ", array) + "]");

for (int j = 0; j < size; j++)
{
    if (array[j] % 2 == 0)
        count++;
}
Console.WriteLine(" -> " + count);
