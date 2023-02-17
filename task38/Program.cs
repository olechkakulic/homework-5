// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int GetMinValue(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int GetMaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
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

int[] array = GetArray(4, 0, 20);
int maxValue = GetMaxValue(array);
int minValue = GetMinValue(array);
int differenceMaxMin = maxValue - minValue;
Console.WriteLine("[" + String.Join(", ", array) + "] -> " + differenceMaxMin);



