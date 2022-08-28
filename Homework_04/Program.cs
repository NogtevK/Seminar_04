/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = int.Parse(Console.ReadLine());

int func(int A)
{
    int exp = 1;
    for (int i = 1; i <= B; i++)
    {
        exp *= A;
    }
    return exp;
}
Console.WriteLine(func(A)); */
//////////////////////
////////////////////////////////////////////////////////////////////////////////////////////
/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* int func(int num)
{
    int sum = 0;
    for (int i = 0; 0 < num; i++)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}
Console.WriteLine(func(452));
Console.WriteLine(func(82));
Console.WriteLine(func(9012)); */



////////////////////////////////////////////////////////////////////////////////////////////////////
/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0, 99);
    }
}
int[] mass = new int[8];
FillArray(mass);

void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(mass);
