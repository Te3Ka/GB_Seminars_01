﻿/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая на вход принимает на вход число и выводит квадрат этого числа.
3 -> 9
-5 -> 25
-7 -> 49
*/

Console.WriteLine("Программа показывает максимальное и минимальное число из двух целых чисел");

Console.WriteLine("Введите два целых числа через Enter");
Console.Write("Число 1 = ");
int num = Int32.Parse(Console.ReadLine());
Console.WriteLine("Квадрат введённого числа " + num + " является = " + num * num);