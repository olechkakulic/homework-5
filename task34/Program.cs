// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int GetCountEvenElemnts(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] GetArray(int size, int start, int end)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(start, end + 1);
    }
    return arr;
}

int[] array = GetArray(5, 100, 999);
int countEven = GetCountEvenElemnts(array);
Console.WriteLine("[" + String.Join(", ", array) + "] -> " + countEven);
