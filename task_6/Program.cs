﻿// Задача 6

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine(" Число " + num + " является: НЕЧЁТНЫМ ");
}
else
{
    Console.WriteLine(" Число " + num + " является: ЧЁТНЫМ ");
}