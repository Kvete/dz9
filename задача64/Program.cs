﻿/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int number =new Random().Next(1,10);
Console.WriteLine(number);

string Recursion (int n)
{
    if (n==1) return "1";   
    else return $"{n}"+Recursion(n-1);
}
Console.WriteLine(Recursion(number));