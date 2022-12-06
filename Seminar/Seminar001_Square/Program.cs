Console.Clear();
Console.Write("Введите число для возведения в квадрат: ");
int numder = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат числа = {numder * numder}");
int number1 = Convert.ToInt32(Math.Pow(numder, 2));
Console.WriteLine($"Квадрат числа = {number1}");
