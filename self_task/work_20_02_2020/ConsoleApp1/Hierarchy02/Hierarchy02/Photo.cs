using System;

namespace Hierarchy02
{
    class Photo : Content
    {
        private string whoIsOnPicture;

        public Photo(int id, string name, DateTime uploadDate, string whoIsOnPicture) : base(id, name, uploadDate)
        {
            this.whoIsOnPicture = whoIsOnPicture;
        }

        public override string ToString()
        {
            return string.Format($"ID: {id}, имя: {name}, дата загрузки: {uploadDate.ToLongDateString()}, на фото: {whoIsOnPicture}");
        }
    }
}