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

int[] last = Perebor(array);

int[] Perebor(int[] mas) {

    int size = mas.Length / 2;
    int[] print = new int[size];

    for (int i = 0; i < size; i++){
        print[i] = mas[i] * mas[(mas.Length - 1) - i]; 
    }
    return print;
}



WriteLine(String.Join(",", array));
WriteLine(String.Join(",", last));