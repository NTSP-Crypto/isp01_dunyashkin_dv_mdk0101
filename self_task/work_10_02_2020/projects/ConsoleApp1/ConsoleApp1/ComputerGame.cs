using System;

namespace ConsoleApp1
{
    class ComputerGame
    {
        public string Name { get; set; }
        public string DeveloperFirm { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; }

        public ComputerGame(string name, string developerFirm, string genre, DateTime publicationDate)
        {
            Name = name;
            DeveloperFirm = developerFirm;
            Genre = genre;
            PublicationDate = publicationDate;
        }

        public override string ToString()
        {
            return string.Format($"Название: {Name}, разработчик: {DeveloperFirm}, дата релиза: {PublicationDate}, жанр: {Genre}");
        }
    }
}
