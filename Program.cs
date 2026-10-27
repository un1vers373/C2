using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                Console.WriteLine("Привет!");
                break;
                
                case 2:
                Console.WriteLine("Пока!");
                break;
        
                case 3:
                Console.WriteLine("я изучаю C#");
                break;
                
                default:
                Console.WriteLine("неизвестная команда");
                break;
            }

        }
    }
}