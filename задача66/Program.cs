/*
Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Recursion(int a, int b)
{
    if (a==b) return a;
    else return Recursion((a+1),b)+a;
}

int m=new Random().Next(0,20);
int n=new Random().Next(0,20);
if (m>n) Console.WriteLine($"сумма натуральных элементов от {n} до {m} ->{Recursion(n,m)}");
else     Console.WriteLine($"сумма натуральных элементов от {m} до {n} ->{Recursion(m,n)}");
