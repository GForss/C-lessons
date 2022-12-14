using System;
using static System.Console;

Clear();

// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

for (int i = 1; i < 50; i++)
{
    WriteLine($"f({i}) = {Fibonacci(i)}");
}