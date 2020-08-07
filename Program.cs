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
            string name = "Tom";  // определяем переменную и инициализируем ее

            Console.WriteLine(name);    // Tom

            name = "Bob";       // меняем значение переменной
            Console.WriteLine(name);    // Bob

            Console.Read();
        }
    }
}
