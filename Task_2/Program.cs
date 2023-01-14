// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
{
    Console.WriteLine("Два числа равны ({0}, {1}).", firstNumber, secondNumber);
}
else if (firstNumber > secondNumber)
{
    Console.WriteLine("Первое ({0}) число больше второго ({1}).", firstNumber, secondNumber);
}
else
{
    Console.WriteLine("Второе ({1}) число больше первого ({0}).", firstNumber, secondNumber);
}