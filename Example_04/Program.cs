﻿/* 1. Найти позицию минимального элемента
в неотсортированной части массива
2. Произвести обмен этого значения со
значением первой неотсортированной позиции
3. Повторять пока есть не отсортированные
элементы 
*/
int[] arr = { 1, 6, 5, 37, 8, 0, 3, 4, 9 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort();
