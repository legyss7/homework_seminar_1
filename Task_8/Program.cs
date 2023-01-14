// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число (N) большее 1: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    Console.Write("Четные числа от 1 до N: ");
    int count = 2;
    while (count <= number)
    {
        if (count % 2 == 0)
            Console.Write($"{count}, ");
        count++;
    }
    Console.Write("\b\b ");
}
else Console.Write("Ошибка!Введенное число должно быть больше 1.");
