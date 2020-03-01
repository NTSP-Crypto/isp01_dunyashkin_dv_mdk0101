using System;

namespace ConsoleApp1
{
    class MonetaryDenomination
    {
        public string SeriesAndNumber { get; set; }
        public int Naminal { get; set; }
        public string NaminalString { get; set; }

        public MonetaryDenomination(string seriesAndNumber, int naminal, string naminalString)
        {
            SeriesAndNumber = seriesAndNumber;
            Naminal = naminal;
            NaminalString = naminalString;
        }

        public override string ToString()
        {
            return string.Format($"Серия и номер: {SeriesAndNumber}, наминал: {Naminal}, наминал прописью: {NaminalString}");
        }
    }
}
