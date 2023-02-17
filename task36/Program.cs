// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int GetSummOddElementsPosition(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
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
int summOddPosEl = GetSummOddElementsPosition(array);
Console.WriteLine("[" + String.Join(", ", array) + "] -> " + summOddPosEl);

