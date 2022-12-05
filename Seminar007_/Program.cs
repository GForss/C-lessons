using System;
using static System.Console;
Clear();

WriteLine("Введите первое число: ");
int number1 = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int number2 = int.Parse(ReadLine());

if (number1 % number2 == 0) {
    WriteLine("Кратно");
} else {
    WriteLine($"{number1 % number2}");
}