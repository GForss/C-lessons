using System;
using static System.Console;

Clear();

int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;

WriteLine(number);

if (a1 < a2) {
    WriteLine(a2);
} else {
    WriteLine(a1);
}