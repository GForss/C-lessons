using System;
using static System.Console;

Clear();

int[] array = MinArr(10);

int[] MinArr(int size) {

    int[] arr = new int[size];

    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(0, 20);
    }
    return arr;
}

int Perebor(int[] mas) {

    int beginning = 0;
    int end = mas.Length;
    int print = 0;
    string theEnd = "Конец";

    for (int i = 0; i < mas.Length / 2; i++){
        print = mas[i] * mas[(mas.Length - 1) - i];
        WriteLine(print);
        
    }
    return theEnd;
}

WriteLine(String.Join(",", array));
WriteLine(Perebor(array));