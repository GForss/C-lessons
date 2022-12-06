using System;
using static System.Console;
Clear();
int number = new Random().Next(100, 1000);

// int a1 = number % 10;
// int a2 = number / 10;
// int a3 = a2 / 10;
// WriteLine(number);
// WriteLine(a1);
// WriteLine(a2);
// WriteLine(a3);
// Write($"{a3}{a1}");

// int a1 = number / 100;
// int a2 = number % 10;

// WriteLine($"{number}-->{a1 * 10 + a2}");

WriteLine($"{number}-->{(number / 100) * 10 + number % 10}");
