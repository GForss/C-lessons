using System;
using static System.Console;
Clear();

Write("Введите число: ");
int number1 = int.Parse(ReadLine());
Write("Введите число: ");
int number2 = int.Parse(ReadLine());

if ((Math.Pow(number1, 2) == number2) || (Math.Pow(number2, 2) == number1)) {
    WriteLine("Да");
} else {
    WriteLine("Нет");
}