﻿int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
 
int fib10 = Fibonachi(10);
 
Console.WriteLine(fib10);