using System;
using static System.Console;

Clear();

// int[] Arr = Push(15);

// int[] Push(int size) {

//     int[] result = new int[size];

//     for (int i = 0; i < size; i++) {
//         result[i] = new Random().Next(-10, 11);
//     }
//     return result;

// }

// WriteLine(String.Join(",", Arr));
// WriteLine("Введите число: ");
// int num = int.Parse(ReadLine());

// int Search(int[] array, int num) {

//     int number = 0;
//     for (int i = 0; i < Arr.Length; i++) {
//         int index = array[i];
//         if (index == num) {
//             number = array[i];
//             break;
//         }
//     }
//     return number;
// }

// WriteLine(Search(Arr, num));

WriteLine("Введите через пробел массив: ");
int[] array = GetArrayFromString(ReadLine());
Write("Введите элемент: ");
int element = int.Parse(ReadLine());

if (FindEllement(array, element)) {
    WriteLine("Yes");
} else {
    WriteLine("No");
}

int[] GetArrayFromString(string stringArray) {

    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];

    for (int i = 0; i < result.Length; i++) {
        result[i] = int.Parse(numS[i]);
    }
    return result;

}

bool FindEllement(int[] inArray, int el) {

    foreach (int item in inArray) {
        
        if (item == el) return true;
    
    }
    return false;
}