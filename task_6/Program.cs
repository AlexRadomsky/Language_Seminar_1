﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int number  = Convert.ToInt32(Console.ReadLine());

if (number  % 2 == 1 || number % 2 == -1)
{
Console.WriteLine("Число " + number  + " нечетное");
}
else
{
Console.WriteLine("Число " + number  + " четное");
}
