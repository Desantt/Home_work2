﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трёх значное число");

int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3)
{
    int result = (Value / 10) % 10;
    Console.WriteLine("Вторая цифра = " + result);
}
else
{
    Console.WriteLine("Вы ввели не трёх значное число");
}
