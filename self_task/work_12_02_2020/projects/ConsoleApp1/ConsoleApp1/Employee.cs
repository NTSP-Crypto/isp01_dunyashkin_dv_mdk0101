using System;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int WorkingExperience { get; set; }

        public Employee(string name, string profession, int workingExperience)
        {
            Name = name;
            Profession = profession;
            WorkingExperience = workingExperience;
        }

        public override string ToString()
        {
            return string.Format($"Имя: {Name}, пол: {Profession}, рабочий стаж: {WorkingExperience}");
        }
    }
}
