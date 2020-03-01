using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Address
    {
        public int Zip { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Home { get; set; }
        public int ApartmentNumber { get; set; }

        public Address(int zip, string city, string street, int home, int apartmentNumber)
        {
            Zip = zip;
            City = city;
            Street = street;
            Home = home;
            ApartmentNumber = apartmentNumber;
        }

        public override string ToString()
        {
            return string.Format($"ZIP: {Zip}, город: {City}, улица: {Street}, дом: {Home}, номер квартиры: {ApartmentNumber}");
        }
    }
}
