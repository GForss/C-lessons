using System;
Console.Clear();
int a1 = 15;
int b1 = 16;
int c1 = 17;
int a2 = 18;
int b2 = 19;
int c2 = 20;
int a3 = 21;
int b3 = 22;
int c3 = 23;

int Max(int arg1, int arg2, int arg3)
{
   int result = arg1;
   if(arg2 > result) result = arg2;
   if(arg3 > result) result = arg3;
   return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max4 = Max(max1, max2, max3);

Console.WriteLine(max4);


