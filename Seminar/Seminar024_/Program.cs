using System;
using static System.Console;

Clear();

WriteLine("Ввседите стороны через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

if(Triangle(int.Parse(nums[0]),int.Parse(nums[1]),int.Parse(nums[2])))
{
    WriteLine($"ДА");
}
else{
    WriteLine($"НЕТ");
}

bool Triangle(int A, int B, int C)
{
    return (((A + B) > C) && ((B + C) > A) && ((A + C) > B));
}