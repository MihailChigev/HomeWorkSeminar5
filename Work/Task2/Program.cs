// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();


System.Console.WriteLine("задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int leftRange = -10;
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
array = FillArrayWithRandomNumber(size, leftRange, rightRange);
Console.Write("[" + string.Join(", ", array) + "]");

int sum = 0;
for (int j = 0; j < size; j += 2)
    sum = sum + array[j];

Console.WriteLine(" -> " + sum);

