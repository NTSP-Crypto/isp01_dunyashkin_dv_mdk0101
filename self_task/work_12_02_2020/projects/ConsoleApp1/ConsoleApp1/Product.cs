using System;

namespace ConsoleApp1
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Product(string name, int quantity, double price, DateTime expirationDate)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            ExpirationDate = expirationDate;

        }

        public override string ToString()
        {
            return string.Format($"Наименование: {Name}, количество: {Quantity}, цена: {Price}, срок годности: {ExpirationDate} дней");
        }
    }
}
