using System;

namespace ConsoleApp2
{
    class Student : User
    {
        private int scholarship;
        private int cource;

        public Student(string name, int age, int cource, int scholarship)
        {
            this.name = name;
            this.age = age;
            this.cource = cource;
            this.scholarship = scholarship;
        }

        public void setScholarship(int scolarship)
        {
            this.scholarship = scolarship;
        }

        public int getScolarship()
        {
            return scholarship;
        }

        public void setCource(int cource)
        {
            this.cource = cource;
        }

        public int getCource()
        {
            return cource;
        }

        public override string ToString()
        {
            return string.Format($"Имя: {name}, возвраст: {age}, курс: {cource}, стипендия: {scholarship}");
        }
    }
}
