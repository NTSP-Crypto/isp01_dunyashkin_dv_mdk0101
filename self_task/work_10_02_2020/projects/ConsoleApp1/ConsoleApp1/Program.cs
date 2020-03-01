using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Петр", 2, "Мужской");
            Console.WriteLine(student);

            Employee employee = new Employee("Иван", "Оффицер", 11);
            Console.WriteLine(employee);

            Workshop workshop = new Workshop("193QP39403", 45);
            Console.WriteLine(workshop);

            Book book = new Book("Колобок", 50.50, "Петр Петров Петрович", "Игорь Игоревичев Игоревич");
            Console.WriteLine(book);

            Test test = new Test("Сергей Сергевьич Сергеев", "Петр Петров Петрович", DateTime.Parse("2020.07.01"), 5);
            Console.WriteLine(test);

            Address address = new Address(54953, "Волжский", "Карла-Маркса", 23, 12);
            Console.WriteLine(address);

            Product product = new Product("Сок", 50, 25, DateTime.Parse("2020.06.20"));
            Console.WriteLine(product);

            TrainingGroup trainingGroup = new TrainingGroup("295423", 20, 2018, "ATP-75");
            Console.WriteLine(trainingGroup);

            MonetaryDenomination monetaryDenomination = new MonetaryDenomination("HE 54237", 200, "Двести");
            Console.WriteLine(monetaryDenomination);

            ComputerGame computerGame = new ComputerGame("GTA 6", "RockstarGames", "Открытый мир", DateTime.Parse("2020.12.10"));
            Console.WriteLine(computerGame);

            Console.ReadKey();
        }
    }
}
