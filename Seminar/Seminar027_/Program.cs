using System;
using static System.Console;

Clear();

WriteLine("Введите через пробел массив: ");
int[] array = Perebor(ReadLine());

int[] Perebor(string array)
{
    string[] numS = array.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length]; 

    for (int i = 0; i < numS.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

WriteLine(String.Join(",", array));

int[] Two = Clone(array);

int[] Clone(int[] Array)
{
    int[] res = new int[Array.Length];

    for (int i = 0; i < Array.Length; i++)
    {
        res[i] = Array[i];
    }
    return res;
}
WriteLine(String.Join(",", array));