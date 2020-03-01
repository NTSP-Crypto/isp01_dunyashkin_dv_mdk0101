using System;

namespace Hierarchy03
{
    class Regular_Employee : Employee
    {
        private float salary;
        private int bonus;

        public Regular_Employee(int id, string name, float salary, int bonus) : base(id, name)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public override string ToString()
        {
            return string.Format($"ID: {id}, имя: {name}, зарплата: {salary}, бонус: {bonus}");
        }
    }
}