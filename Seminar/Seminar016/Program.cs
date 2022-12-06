using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");

int Method(int number) {

    int itog = 1;

    for (int i = 1; i <= number; i++) {

        itog *= i;

    }
    return itog;
}

WriteLine(Method(int.Parse(ReadLine())));