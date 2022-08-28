/* Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */

int func(int num)
{
    int count = 0;
    for (int i = 0; num > i;)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine(func(456));
Console.WriteLine(func(78));
Console.WriteLine(func(458966));



/* Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());
int num = 0;
while (i > 0)
{
    i = i / 10;
    num++;
}
Console.WriteLine(num); */