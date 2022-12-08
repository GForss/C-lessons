using System;
using static System.Console;

Clear();

int[] arr = BigArray(123);

int[] BigArray(int Size) {

    int[] result = new int[Size];

    for (int i = 0; i < Size; i++) {
        //result[i] = new Random().Next(int.MinValue, int.MaxValue); - от минус бесконечность до плюс бесконечности
        result[i] = new Random().Next(1, 200);
    }
    return result;
}

int Bro(int[] array) {

    int itog = 0;

    for (int i = 0; i < array.Length; i++) {

        if (array[i] > 10 && array[i] < 99) {
            itog++;
        }
        
    }
    return itog;
}

WriteLine(String.Join(",", arr));
WriteLine(Bro(arr));