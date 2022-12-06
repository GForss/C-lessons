using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
int GetSumm = summ(number);
WriteLine($"Сумма = {GetSumm}");

int summ(int Abc) {

    int itog = 0;   

    for (int i = 1; i <= Abc; i++) {
        itog += i;
    }
    return itog;
}