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
            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");
        }
    }
}
