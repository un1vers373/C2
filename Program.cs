using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Сложение: " + (number + number1));
Console.WriteLine("Вычитание: " + (number - number1));
Console.WriteLine("Умножение: " + (number * number1));

if (number1 != 0)
{
    Console.WriteLine("Деление: " + ((double)number / number1));
    Console.WriteLine("Остаток от деления: " + (number % number1));
}
else
{
    Console.WriteLine("На ноль делить нельзя!");
}
        }
    }
}