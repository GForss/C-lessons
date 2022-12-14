using System;
using static System.Console;

Clear();

int[] arr = NewMass(10);

int[] NewMass(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

WriteLine(String.Join(",", arr));

int[] arrTwo = Upheaval(arr);

int[] Upheaval(int[] mass)
{
    int[] revers = new int[mass.Length];

    for (int i = 0; i < mass.Length; i++)
    {
        revers[i] = mass[(mass.Length -1) - i];
    }
    return revers;
}

WriteLine(String.Join(",", arrTwo));



void ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int k = arr[i];
        arr[i] = arr[(arr.Length - 1) - i];
        arr[(arr.Length - 1) - i] = k;
    }
}
ReversArray(arr);
WriteLine(String.Join(",", arr));