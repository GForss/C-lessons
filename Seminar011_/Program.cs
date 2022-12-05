using System;
using static System.Console;
Clear();

WriteLine("Введите номер четверти: ");
int x = int.Parse(ReadLine());

switch(x) {
    case 1: {
        WriteLine("x>0,y>0");
        break;
    }
    case 2: {
        WriteLine("x<0,y>0");
        break;
    }
    case 3: {
        WriteLine("x<0,y<0");
        break;
    }
    case 4: {
        WriteLine("x>0,y<0");
        break;
    }
    default: {
        WriteLine("Неверная четверть");
        break;
    }
}