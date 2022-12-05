using System;
using static System.Console;
Clear();

WriteLine("Введите число: ");
int numbr = int.Parse(ReadLine());

for (int i = 1; i <= numbr; i++) {
    WriteLine(Math.Pow(i, 2));
} 