/* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i <= A; i++)
{
    sum += i;
}
Console.WriteLine(sum);
