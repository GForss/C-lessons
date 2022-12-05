using System;
using static System.Console;
Clear();

WriteLine("Введите координату X1: ");
int x1 = int.Parse(ReadLine());
WriteLine("Введите координату Y1: ");
int y1 = int.Parse(ReadLine());
WriteLine("Введите координату X2: ");
int x2 = int.Parse(ReadLine());
WriteLine("Введите координату Y2: ");
int y2 = int.Parse(ReadLine());

WriteLine(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)));

