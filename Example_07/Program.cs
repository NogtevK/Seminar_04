﻿/* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int func(int N)
{
    int fact = 1;
    for (int i = 1; i <= N; i++)
    {
        fact = fact * i;
    }
    return fact;
}
Console.WriteLine("Factorial: " +func(N));