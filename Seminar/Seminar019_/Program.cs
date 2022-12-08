using System;
using static System.Console;

Clear();

int[] arr = GetArray(10, -10, 10);
int[] ReversArr = new int[arr.Length];

for (int i = 0; i < arr.Length; i++) {

    int pom = arr[i];

    if (pom < 0) {
        ReversArr[i] = Math.Abs(arr[i]);
    } else {
        ReversArr[i] = -Math.Abs(arr[i]);
    }
}

WriteLine(String.Join(",", arr));
WriteLine(String.Join(",", ReversArr));

int[] GetArray(int size, int min, int max) {

    int[] result = new int[size];

    for (int i = 0; i < size; i++) {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}