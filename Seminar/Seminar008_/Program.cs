using System;
using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());

if ((number % 7 == 0) && (number % 23 == 0)) {
    WriteLine("Кратно");
} else {
    WriteLine("Не кратно");
}