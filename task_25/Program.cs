﻿/*Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.WriteLine("Введите число : ");
double numb = double.Parse(Console.ReadLine()!);
double pow = double.Parse(Console.ReadLine()!);
Console.Write(Math.Pow(numb, pow));
