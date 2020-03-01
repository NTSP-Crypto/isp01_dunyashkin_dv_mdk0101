using System;

namespace ConsoleApp1
{
    class Book
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public double Price { get; set; }

        public Book(string title, double price, params string[] authors)
        {
            Title = title;
            Authors = authors;
            Price = price;
        }

        public override string ToString()
        {
            if (Authors == null)
            {
                Console.WriteLine("Неизвестный автор");
            }

            return string.Format($"Название: {Title}, цена: {Price}, авторы: {string.Join(", ", Authors)}");
        }
    }
}