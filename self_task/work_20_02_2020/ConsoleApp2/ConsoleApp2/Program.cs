using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker01 = new Worker("Иван", 25, 1000);
            Worker worker02 = new Worker("Вася", 26, 2000);

            Console.WriteLine($"Зарплата {worker01.getName()}: {worker01.getSalary()}");
            Console.WriteLine($"Зарплата {worker02.getName()}: {worker02.getSalary()}");

            Console.ReadLine();
        }
    }
}
