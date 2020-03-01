using System;

namespace ConsoleApp1
{
    class Workshop
    {
        public string StringCipher { get; set; }
        public int NumberOfEmployees { get; set; }

        public Workshop(string stringCipher, int numberOfEmployees)
        {
            StringCipher = stringCipher;
            NumberOfEmployees = numberOfEmployees;
        }

        public override string ToString()
        {
            return string.Format($"Строковый шифр: {StringCipher}, количество служащих: {NumberOfEmployees}");
        }
    }
}
