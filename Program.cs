using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
           int number = int.Parse(Console.ReadLine());
            if (number >= 10 && number <= 20)
            {
                Console.WriteLine("Число в диапазоне!");
            }
            else
            {
                Console.WriteLine("Число не в диапазоне!");
            }
            bool isBlocked = false;
            if (!isBlocked)
            {
                Console.WriteLine("Доступ разрешен!");
            }
            else
            {
                Console.WriteLine("Доступ запрещен!");
            }
        }
    }
}