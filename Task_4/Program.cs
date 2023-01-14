// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber && firstNumber == thirdNumber)
{
    Console.WriteLine("Три числа ({0}, {1}, {2}) равны друг другу.",
                    firstNumber, secondNumber, thirdNumber);
}
else if (firstNumber == secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Первое ({0}) и второе ({1}) числа равны и больше третьего ({2}).",
                        firstNumber, secondNumber, thirdNumber);
    }
    else
    {
        Console.WriteLine("Третье число ({2}) больше двух других равных друг другу ({0}, {1}).",
                        firstNumber, secondNumber, thirdNumber);
    }
}
else if (secondNumber == thirdNumber)
{
    if (secondNumber > firstNumber)
    {
        Console.WriteLine("Второе ({1}) и третье ({2}) числа равны и больше первого ({0}).",
                        firstNumber, secondNumber, thirdNumber);
    }
    else
    {
        Console.WriteLine("Первое число ({0}) больше двух других равных друг другу ({1}, {2}).",
                        firstNumber, secondNumber, thirdNumber);
    }
}
else if (firstNumber == thirdNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Первое ({0}) и третье ({2}) числа равны и больше второго ({1}).",
                        firstNumber, secondNumber, thirdNumber);
    }
    else
    {
        Console.WriteLine("Второе число ({1}) больше двух других равных друг другу ({0}, {2}).",
                        firstNumber, secondNumber, thirdNumber);
    }
}
else if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine("Первое число ({0}) больше двух остальных ({1}, {2}).",
                                    firstNumber, secondNumber, thirdNumber);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine("Второе число ({1}) больше двух остальных ({0}, {2}).",
                                    firstNumber, secondNumber, thirdNumber);
}
else // if(thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.WriteLine("Третье число ({2}) больше двух остальных ({0}, {1}).",
                                    firstNumber, secondNumber, thirdNumber);
}

