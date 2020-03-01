using System;

namespace Hierarchy02
{
    class Video : Content
    {
        private string length;

        public Video(int id, string name, DateTime uploadDate, string length) : base(id, name, uploadDate)
        {
            this.length = length;
        }

        public override string ToString()
        {
            return string.Format($"ID: {id}, имя: {name}, дата загрузки: {uploadDate.ToLongDateString()} длина: {length}");
        }
    }
}