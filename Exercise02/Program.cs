﻿/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> Да
a = 2, b = 10 -> Нет
a = -3, b = 9 -> Нет
*/

Console.WriteLine("Программа проверяет, является ли первое введённое целое число квадратом второго введённого целого числа");
Console.Write("Введите первое число (подразумеваемый квадрат) = ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число = ");
int b = Int32.Parse(Console.ReadLine());

if (a == b * b)
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
else
    Console.WriteLine("Число " + a + " НЕявляется квадратом числа " + b);