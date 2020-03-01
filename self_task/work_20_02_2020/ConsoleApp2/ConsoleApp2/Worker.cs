using System;

namespace ConsoleApp2
{
    class Worker : User
    {
        private float salary;

        public Worker() { }
        public Worker(string name, int age, float salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public float getSalary()
        {
            return salary;
        }

        public void setSalary(float salary)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return string.Format($"Имя: {name}, возвраст: {age}, зарплата: {salary}");
        }
    }
}
