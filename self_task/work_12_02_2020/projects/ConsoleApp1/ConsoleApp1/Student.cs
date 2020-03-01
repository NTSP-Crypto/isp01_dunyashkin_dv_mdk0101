using System;

namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public readonly string Gender;

        public Student(string name, int course, string gender)
        {
            Name = name;
            Course = course;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format($"Имя: {Name}, пол: {Gender}, курс: {Course}");
        }
    }
}
