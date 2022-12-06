using System;

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number1 = -number;

while(number1 <= number)
{
    Console.WriteLine(number1);
    number1++;
}