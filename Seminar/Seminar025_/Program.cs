using System;
using static System.Console;

Clear();

WriteLine("Ввседите число: ");
int num = int.Parse(ReadLine());
string s1 = Convert.ToString(num, 2);
WriteLine(s1);
string s2 = Recurs(num, 2);

string Recurs(int numb, int sus)
{
    string result = "";
    string chars = "0123456789ABCDEF";

    while (numb > 0)
    {
        int k = numb / sus;
        int ost = numb - k * sus;
        result = chars[ost].ToString() + result;
        numb /= sus;
    }
    return result;
}

WriteLine(s2);