using System;

namespace Hierarchy01
{
    class Person
    {
        protected int age;
        public string name;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Имя: {name}");
        }

        public override string ToString()
        {
            return string.Format($"Имя: {name}, возраст: {age}");
        }
    }
}
