// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine("Первое число ({0}) больше двух остальных ({1}, {2})",
                                    firstNumber, secondNumber, thirdNumber);
}
else if (secondNumber > firstNumber && secondNumber > thirdNumber)
{
    Console.WriteLine("Второе число ({1}) больше двух остальных ({0}, {2})",
                                    firstNumber, secondNumber, thirdNumber);
}
else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
{
    Console.WriteLine("Третье число ({2}) больше двух остальных ({0}, {1})",
                                    firstNumber, secondNumber, thirdNumber);
}
else Console.WriteLine("Ошибка! Введено два или три одинаковых числа.");
