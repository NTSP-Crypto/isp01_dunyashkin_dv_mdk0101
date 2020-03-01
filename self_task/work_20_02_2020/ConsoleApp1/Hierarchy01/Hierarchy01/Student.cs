using System;

namespace Hierarchy01
{
    class Student : Person
    {
        private int cource;
        private string group;

        public Student(string name, int age, int cource, string group) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.cource = cource;
            this.group = group;
        }
        public void NextCource()
        {
            cource++;
        }

        public override void Print()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}, курс: {cource}, группа: {group}");
        }

        public override string ToString()
        {
            return string.Format($"Имя: {name}, возраст: {age}, курс: {cource}, группа: {group}");
        }
    }
}
