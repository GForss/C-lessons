using System;
using static System.Console;

Clear();

// f(n) = f(n-1) + f(n-2)

WriteLine("Ввседите число");
int num = int.Parse(ReadLine());

// int Fibon(int n)
// {
//     if (n == 1 || n == 2)
//     {
//         return 1;
//     }
//     else
//     {
//         return Fibon(n - 1) + Fibon(n - 2);
//     }
// }

// for (int i = 1; i < num; i++)
// {
//     WriteLine($"f({i}) = {Fibon(i)}");
// }

// f(n) = f(n-1) + f(n-2)

int[] arrayFib = Fibon(num);

int[] Fibon(int n)
{
    int[] arr = new int[n];
    arr[0] = 1;
    arr[1] = 1;
    for (int i = 2; i < n; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

WriteLine(String.Join(",", arrayFib));