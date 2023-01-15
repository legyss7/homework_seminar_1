// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число (N) отличное от 1: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Четные числа от 1 до N: ");
if (number > 1)
{
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0)
            Console.Write($"{count}, ");
        count++;
    }
}
else
{
    int count = 1;
    while (count >= number)
    {
        if (count % 2 == 0)
            Console.Write($"{count}, ");
        count--;
    }
}
Console.WriteLine("\b\b.");

