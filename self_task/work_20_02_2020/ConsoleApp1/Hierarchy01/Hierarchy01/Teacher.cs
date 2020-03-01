using System;
using System.Collections.Generic;

namespace Hierarchy01
{
    class Teacher : Person
    {
        private List<string> disciplines;
        private string powerDisciplines;

        public Teacher(string name, int age, params string[] disciplines) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.disciplines = new List<string>(disciplines);
        }

        public void AddDisciplines(string discipline)
        {
            disciplines.Add(discipline);
        }

        public void RemoveDisciplines(string removeDiscripline)
        {
            disciplines.Remove(removeDiscripline);
        }

        public override void Print()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}");
            foreach (var item in disciplines)
            {
                Console.Write(string.Format(item, ", "));
            }
        }

        public override string ToString()
        {
            foreach (var item in disciplines)
                powerDisciplines += item + "; ";

            return string.Format($"Имя: {name}, возраст: {age}, дисциплина: {powerDisciplines}");
        }
    }
}
