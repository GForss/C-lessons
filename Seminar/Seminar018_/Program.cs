using System;
using static System.Console;

Clear();
int[] array = GetArray(12, -9, 9);
int positivSumm = 0;
int negativSumm = 0;

foreach (int item in array) {
    if (item > 0) {
        positivSumm += item;
    } else {
        negativSumm += item;
    }
}

WriteLine(String.Join(",", array));
WriteLine($"Сумма положительных чисел = {positivSumm}, Сумма отрицательных чисел = {negativSumm}");

int[] GetArray(int size, int min, int max) {

    int[] result = new int[size];

    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}