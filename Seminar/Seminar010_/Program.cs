using System;
using static System.Console;
Clear();

WriteLine("Введите координату Х:");
int x = int.Parse(ReadLine());
WriteLine("Введите координату Y:");
int y = int.Parse(ReadLine());

if (x > 0 && y > 0) {
    WriteLine("I");
} else if (x < 0 && y > 0) {
    WriteLine("II");
} else if (x < 0 && y < 0) {
    WriteLine("III");
} else if (x > 0 && y < 0) {
    WriteLine("IV");
}