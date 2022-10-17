/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Recursion(int m, int n)
{
    if (m==0)        return n+1;
    if (n==0)        return Recursion(m-1,1);
    else             return Recursion(m-1,Recursion(m,n-1));
}
int m=0; //new Random().Next(0,3);
Console.WriteLine(m);
int n=2; //new Random().Next(0,8);
Console.WriteLine(n);
Console.WriteLine(Recursion(m,n));