﻿// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
    Console.WriteLine("Введенное число (" + number + ") является четным.");
else
    Console.WriteLine("Введенное число (" + number + ") является нечетным."); 
