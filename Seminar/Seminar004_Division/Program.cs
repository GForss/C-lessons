using System;

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int number1 = number % 10;
Console.WriteLine(number1);