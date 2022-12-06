using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");

int Method(int number) {

    int count = 0;

    while (number > 0) {
        number /= 10;
        count++;
    }
    return count;
}

WriteLine($"{Method(int.Parse(ReadLine()))}");