Console.Clear();
Console.WriteLine("Введите первое число для проверки ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки ");
int number2 = int.Parse(Console.ReadLine());
if(Convert.ToInt32(Math.Pow(number2, 2)) == number1)
{
Console.WriteLine("Верно, первое число является квадратом второго!");
}
else{
Console.WriteLine("Нет, первое число не является квадратом второго!");
}