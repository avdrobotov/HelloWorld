using System;

namespace HelloWorld
{
    class Program
    {
        /*
           программа, которая спрашивает у пользователя имя
           и выводит его на консоль
       */
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name}");    // выводим имя на консоль   
            Console.ReadKey();
        }
    }
}
